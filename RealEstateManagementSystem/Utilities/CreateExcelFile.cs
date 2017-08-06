using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.Reflection;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System.Text.RegularExpressions;
using System.IO;
namespace ExportToExcel
{
    //
    //  Note: if you plan to use this in an ASP.Net application, remember to add a reference to "System.Web", and to uncomment
    //  the "INCLUDE_WEB_FUNCTIONS" definition at the top of this file.

    public class CreateExcelFile
    {

        const int DATE_FORMAT_ID = 1;

        public static bool CreateExcelDocument<T>(List<T> list, string xlsxFilePath)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(ListToDataTable(list));
            return CreateExcelDocument(ds, xlsxFilePath);
        }

        #region Helper Functions

        //Making it "nullable-friendly".
        public static DataTable ListToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, GetNullableType(info.PropertyType)));
            }
            foreach (T t in list)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyInfo info in typeof(T).GetProperties())
                {
                    if (!IsNullableType(info.PropertyType))
                        row[info.Name] = info.GetValue(t, null);
                    else
                        row[info.Name] = (info.GetValue(t, null) ?? DBNull.Value);
                }
                dt.Rows.Add(row);
            }
            return dt;
        }

        private static Type GetNullableType(Type t)
        {
            Type returnType = t;
            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                returnType = Nullable.GetUnderlyingType(t);
            }
            return returnType;
        }

        private static bool IsNullableType(Type type)
        {
            return (type == typeof(string) ||
                    type.IsArray ||
                    (type.IsGenericType &&
                     type.GetGenericTypeDefinition().Equals(typeof(Nullable<>))));
        }

        public static bool CreateExcelDocument(DataTable dt, string xlsxFilePath)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            bool result = CreateExcelDocument(ds, xlsxFilePath);
            ds.Tables.Remove(dt);
            return result;
        }

        #endregion

        #region Create Excel document methods

        /// <summary>
        /// Create an Excel file, and write it out to a MemoryStream (rather than directly to a file)
        /// </summary>
        /// <param name="dt">DataTable containing the data to be written to the Excel.</param>
        /// <param name="filename">The filename (without a path) to call the new Excel file.</param>
        /// <param name="Response">HttpResponse of the current page.</param>
        /// <returns>True if it was created succesfully, otherwise false.</returns>
        public static bool CreateExcelDocument(DataSet dataset, string filename, System.Web.HttpResponse Response)
        {
            try
            {
                CreateExcelDocumentAsStream(dataset, filename, Response);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }

        public static bool CreateExcelDocument(DataTable datatable, string filename, System.Web.HttpResponse Response)
        {
            try
            {
                DataSet dataset = new DataSet();
                //ds.Tables.Add(dt);
                /*To Handle error : DataTable already belongs to another DataSet.*/
                DataTable datatableCopy = new DataTable();
                datatableCopy = datatable.Copy();
                dataset.Tables.Add(datatableCopy);
                /**/
                CreateExcelDocument(dataset, filename, Response);
                dataset.Tables.Remove(datatableCopy);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }

        public static bool CreateExcelDocument<T>(List<T> list, string filename, System.Web.HttpResponse Response)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.Tables.Add(ListToDataTable(list));
                CreateExcelDocumentAsStream(ds, filename, Response);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Create an Excel file, and write it out to a MemoryStream (rather than directly to a file)
        /// </summary>
        /// <param name="ds">DataSet containing the data to be written to the Excel.</param>
        /// <param name="filename">The filename (without a path) to call the new Excel file.</param>
        /// <param name="Response">HttpResponse of the current page.</param>
        /// <returns>Either a MemoryStream, or NULL if something goes wrong.</returns>
        public static bool CreateExcelDocumentAsStream(DataSet dataset, string filename, System.Web.HttpResponse Response)
        {
            try
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook, true))
                {
                    WriteExcelFile(dataset, document);
                }
                stream.Flush();
                stream.Position = 0;

                Response.ClearContent();
                Response.Clear();
                Response.Buffer = true;
                Response.Charset = "";

                //  NOTE: If you get an "HttpCacheability does not exist" error on the following line, make sure you have
                //  manually added System.Web to this project's References.

                Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
                Response.AddHeader("content-disposition", "attachment; filename=" + filename);
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                byte[] data1 = new byte[stream.Length];
                stream.Read(data1, 0, data1.Length);
                stream.Close();
                Response.BinaryWrite(data1);
                Response.Flush();

                // Needed to replace "Response.End();" with the following 3 lines, to make sure the Excel was fully written to the Response
                System.Web.HttpContext.Current.Response.Flush();
                System.Web.HttpContext.Current.Response.SuppressContent = true;
                System.Web.HttpContext.Current.ApplicationInstance.CompleteRequest();

                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Create an Excel file, and write it to a file.
        /// </summary>
        /// <param name="ds">DataSet containing the data to be written to the Excel.</param>
        /// <param name="excelFilename">Name of file to be written.</param>
        /// <returns>True if successful, false if something went wrong.</returns>
        public static bool CreateExcelDocument(DataSet ds, string excelFilename)
        {
            try
            {
                excelFilename = excelFilename + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(excelFilename, SpreadsheetDocumentType.Workbook))
                {
                    WriteExcelFile(ds, document);
                }
                Trace.WriteLine("Successfully created: " + excelFilename);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }

        private static void WriteExcelFile(DataSet ds, SpreadsheetDocument spreadsheet)
        {
            //  Create the Excel file contents.  This function is used when creating an Excel file either writing 
            //  to a file, or writing to a MemoryStream.
            spreadsheet.AddWorkbookPart();
            spreadsheet.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

            //  the following line of code (which prevents crashes in Excel 2010)
            spreadsheet.WorkbookPart.Workbook.Append(new BookViews(new WorkbookView()));

            // If we don't add a "WorkbookStylesPart", OLEDB will refuse to connect to this .xlsx file !
            WorkbookStylesPart workbookStylesPart = spreadsheet.WorkbookPart.AddNewPart<WorkbookStylesPart>("rIdStyles");

            workbookStylesPart.Stylesheet = CreateStylesheet();
            workbookStylesPart.Stylesheet.Save();

            //  Loop through each of the DataTables in our DataSet, and create a new Excel Worksheet for each.
            uint worksheetNumber = 1;
            Sheets sheets = spreadsheet.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());
            foreach (DataTable dt in ds.Tables)
            {
                //  For each worksheet you want to create
                string worksheetName = dt.TableName;

                //  Create worksheet part, and add it to the sheets collection in workbook
                WorksheetPart newWorksheetPart = spreadsheet.WorkbookPart.AddNewPart<WorksheetPart>();

                Sheet sheet = new Sheet() { Id = spreadsheet.WorkbookPart.GetIdOfPart(newWorksheetPart), SheetId = worksheetNumber, Name = worksheetName };
                
                // If you want to define the Column Widths for a Worksheet, you need to do this *before* appending the SheetData
                // http://social.msdn.microsoft.com/Forums/en-US/oxmlsdk/thread/1d93eca8-2949-4d12-8dd9-15cc24128b10/
                sheets.Append(sheet);

                //  Append this worksheet's data to our Workbook, using OpenXmlWriter, to prevent memory problems
                WriteDataTableToExcelWorksheet(dt, newWorksheetPart);
                worksheetNumber++;
            }

            spreadsheet.WorkbookPart.Workbook.Save();
        }

        private static void WriteDataTableToExcelWorksheet(DataTable dataTable, WorksheetPart worksheetPart)
        {
            OpenXmlWriter openXmlWriter = OpenXmlWriter.Create(worksheetPart, Encoding.ASCII);
            openXmlWriter.WriteStartElement(new Worksheet());
            openXmlWriter.WriteStartElement(new SheetData());

            string cellValue = "";            

            //  Create a Header Row in our Excel file, containing one header for each Column of data in our DataTable.
            //
            //  We'll also create an array, showing which type each column of data is (Text or Numeric), so when we come to write the actual
            //  cells of data, we'll know if to write Text values or Numeric cell values.
            int numberOfColumns = dataTable.Columns.Count;

            bool[] IsNumericColumn = new bool[numberOfColumns];
            bool[] IsDateColumn = new bool[numberOfColumns];
            bool[] IsDecimalColumn = new bool[numberOfColumns];

            string[] excelColumnNames = new string[numberOfColumns];
            for (int n = 0; n < numberOfColumns; n++)
                excelColumnNames[n] = GetExcelColumnName(n);

            //
            //  Create the Header row in our Excel Worksheet
            //

            uint rowIndex = 1;

            openXmlWriter.WriteStartElement(new Row { RowIndex = 1 });

            for (int colInx = 0; colInx < numberOfColumns; colInx++)
            {
                DataColumn col = dataTable.Columns[colInx];

                AppendHeaderTextCell(excelColumnNames[colInx] + "1", col.ColumnName, ref openXmlWriter);
                IsNumericColumn[colInx] = (col.DataType.FullName == "System.Int32") || (col.DataType.FullName == "System.Double") || (col.DataType.FullName == "System.Single");
                IsDateColumn[colInx] = (col.DataType.FullName == "System.DateTime");
                IsDecimalColumn[colInx] = (col.DataType.FullName == "System.Decimal");
            }

            openXmlWriter.WriteEndElement();   //  End of header "Row"

            //
            //  Now, step through each row of data in our DataTable...
            //
            double cellNumericValue = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                // ...create a new row, and append a set of this row's data to it.
                ++rowIndex;

                openXmlWriter.WriteStartElement(new Row { RowIndex = rowIndex });

                for (int colInx = 0; colInx < numberOfColumns; colInx++)
                {
                    cellValue = dr.ItemArray[colInx].ToString();
                    cellValue = ReplaceHexadecimalSymbols(cellValue);

                    // Create cell with data
                    if (IsNumericColumn[colInx])
                    {
                        //  For numeric cells, make sure our input data IS a number, then write it out to the Excel file.
                        //  If this numeric value is NULL, then don't write anything to the Excel file.
                        cellNumericValue = 0;
                        if (double.TryParse(cellValue, out cellNumericValue))
                        {
                            cellValue = cellNumericValue.ToString();
                            AppendNumericCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, ref openXmlWriter);
                        }
                    }
                    else if (IsDateColumn[colInx])
                    {
                        //  This is a date value.
                        DateTime dtValue;
                        string strValue = "";
                        if (DateTime.TryParse(cellValue, out dtValue))
                            strValue = dtValue.ToString();
                        AppendTextCell(excelColumnNames[colInx] + rowIndex.ToString(), strValue, ref openXmlWriter);
                    }
                    /*Currency*/
                    else if (IsDecimalColumn[colInx])
                    {
                        cellNumericValue = 0;
                        double cellValueCurrency = 0;
                        if (double.TryParse(cellValue, out cellNumericValue))
                        {
                            cellValueCurrency = cellNumericValue;
                            AppendDecimalCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValueCurrency, ref openXmlWriter);

                            //cellValue = cellNumericValue.ToString();
                            //AppendNumericCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, ref openXmlWriter);

                            ///*Kailash(20160426) : New patch for adding $ symbol for currency column*/
                            ////cellValue = String.Format("{0:C2}", cellNumericValue);
                            ////AppendTextCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, ref openXmlWriter);
                        }
                    }
                    /*end Currency*/
                    else
                    {
                        //  For text cells, just write the input data straight out to the Excel file.
                        AppendTextCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, ref openXmlWriter);
                    }
                }
                openXmlWriter.WriteEndElement(); //  End of Row
            }
            openXmlWriter.WriteEndElement(); //  End of SheetData
            openXmlWriter.WriteEndElement(); //  End of worksheet

            openXmlWriter.Close();
        }

        #region | Create and Append : Excel Column |

        //  Convert a zero-based column index into an Excel column reference  (A, B, C.. Y, Y, AA, AB, AC... AY, AZ, B1, B2..)
        public static string GetExcelColumnName(int columnIndex)
        {
            //  eg  (0) should return "A"
            //      (1) should return "B"
            //      (25) should return "Z"
            //      (26) should return "AA"
            //      (27) should return "AB"
            //      ..etc..
            char firstChar;
            char secondChar;
            char thirdChar;

            if (columnIndex < 26)
            {
                return ((char)('A' + columnIndex)).ToString();
            }

            if (columnIndex < 702)
            {
                firstChar = (char)('A' + (columnIndex / 26) - 1);
                secondChar = (char)('A' + (columnIndex % 26));

                return string.Format("{0}{1}", firstChar, secondChar);
            }

            int firstInt = columnIndex / 26 / 26;
            int secondInt = (columnIndex - firstInt * 26 * 26) / 26;
            if (secondInt == 0)
            {
                secondInt = 26;
                firstInt = firstInt - 1;
            }
            int thirdInt = (columnIndex - firstInt * 26 * 26 - secondInt * 26);

            firstChar = (char)('A' + firstInt - 1);
            secondChar = (char)('A' + secondInt - 1);
            thirdChar = (char)('A' + thirdInt);

            return string.Format("{0}{1}{2}", firstChar, secondChar, thirdChar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cellReference"></param>
        /// <param name="cellStringValue"></param>
        /// <param name="writer"></param>
        /// <param name="yourTypeCode"></param>
        private static void AppendHeaderTextCell(string cellReference, string cellStringValue, ref OpenXmlWriter writer, TypeCode yourTypeCode = TypeCode.String)
        {
            Cell cell = new Cell
            {
                CellValue = new CellValue(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.String,
                StyleIndex = 6
            };
            writer.WriteElement(cell);
        }

        #endregion

        #region | Create and Append : Excel Cell |

        private static void AppendTextCell(string cellReference, string cellStringValue, ref OpenXmlWriter writer, TypeCode yourTypeCode = TypeCode.String)
        {
            Cell cell = new Cell
            {
                CellValue = new CellValue(cellStringValue),
                CellReference = cellReference,
                DataType = CellValues.String,
                StyleIndex = 4
            };

            writer.WriteElement(cell);
        }

        private static void AppendDecimalCell(string cellReference, double cellStringValue, ref OpenXmlWriter writer)
        {
            //  Add a new Excel Cell to our Row 
            writer.WriteElement(new Cell
            {                
                CellValue = new CellValue(((double)cellStringValue).ToString("f2")),
                CellReference = cellReference,
                StyleIndex = 3

            });
        }
        
        private static void AppendNumericCell(string cellReference, string cellStringValue, ref OpenXmlWriter writer)
        {
            //  Add a new Excel Cell to our Row 
            writer.WriteElement(new Cell
            {
                DataType = new EnumValue<CellValues>(CellValues.Number),
                CellValue = new CellValue(Convert.ToString(cellStringValue)),
                CellReference = cellReference,
                StyleIndex = 0

            });

        }

        //this method is used for number formating for numeric values(ex : year value 2,016)
        //private static void AppendNumericCell(string cellReference, string cellStringValue, ref OpenXmlWriter writer)
        //{
        //    //  Add a new Excel Cell to our Row 
        //    writer.WriteElement(new Cell
        //    {
        //        CellValue = new CellValue(cellStringValue.ToString()),
        //        CellReference = cellReference,
        //        StyleIndex = 2

        //    });

        //}

        #endregion

        private static string ReplaceHexadecimalSymbols(string txt)
        {
            //string r = "[\x00-\x08\x0B\x0C\x0E-\x1F\x26]";
            /*Grp-150 : For Maintaining & symbol in string, removed hexadecimal value x26*/
            string r = "[\x00-\x08\x0B\x0C\x0E-\x1F]";
            return Regex.Replace(txt, r, "", RegexOptions.Compiled);
        }
        
        #region Excel : StyleSheet

        private static Stylesheet CreateStylesheet()
        {
            Stylesheet ss = new Stylesheet();

            Fonts fts = new Fonts();
            DocumentFormat.OpenXml.Spreadsheet.Font ft = new DocumentFormat.OpenXml.Spreadsheet.Font();
            FontName ftn = new FontName();
            ftn.Val = StringValue.FromString("Tahoma");
            DocumentFormat.OpenXml.Spreadsheet.FontSize ftsz = new DocumentFormat.OpenXml.Spreadsheet.FontSize();
            ftsz.Val = DoubleValue.FromDouble(10);
            ft.FontName = ftn;
            ft.FontSize = ftsz;            
            fts.Append(ft);

            ft = new DocumentFormat.OpenXml.Spreadsheet.Font(); //bold
            ftn = new FontName();
            ftn.Val = StringValue.FromString("Tahoma");
            ftsz = new DocumentFormat.OpenXml.Spreadsheet.FontSize();
            ftsz.Val = DoubleValue.FromDouble(10);
            ft.FontName = ftn;
            ft.FontSize = ftsz;
            Bold bold = new Bold();
            ft.Bold = bold;
            fts.Append(ft);

            fts.Count = UInt32Value.FromUInt32((uint)fts.ChildElements.Count);

            Fills fills = new Fills();
            Fill fill;
            PatternFill patternFill;
            fill = new Fill();
            patternFill = new PatternFill();
            patternFill.PatternType = PatternValues.None;
            fill.PatternFill = patternFill;
            fills.Append(fill);

            fill = new Fill();
            patternFill = new PatternFill();
            patternFill.PatternType = PatternValues.Gray125;
            fill.PatternFill = patternFill;
            fills.Append(fill);

            //fill = new Fill();
            //patternFill = new PatternFill();
            //patternFill.PatternType = PatternValues.Solid;
            //patternFill.ForegroundColor = new ForegroundColor();
            //patternFill.ForegroundColor.Rgb = HexBinaryValue.FromString("00ff9728");
            //patternFill.BackgroundColor = new BackgroundColor();
            //patternFill.BackgroundColor.Rgb = patternFill.ForegroundColor.Rgb;
            //fill.PatternFill = patternFill;
            //fills.Append(fill);

            fills.Count = UInt32Value.FromUInt32((uint)fills.ChildElements.Count);

            Borders borders = new Borders();
            Border border = new Border();
            border.LeftBorder = new LeftBorder();
            border.RightBorder = new RightBorder();
            border.TopBorder = new TopBorder();
            border.BottomBorder = new BottomBorder();
            border.DiagonalBorder = new DiagonalBorder();
            borders.Append(border);

            border = new Border();
            border.LeftBorder = new LeftBorder();
            border.LeftBorder.Style = BorderStyleValues.Thin;
            border.RightBorder = new RightBorder();
            border.RightBorder.Style = BorderStyleValues.Thin;
            border.TopBorder = new TopBorder();
            border.TopBorder.Style = BorderStyleValues.Thin;
            border.BottomBorder = new BottomBorder();
            border.BottomBorder.Style = BorderStyleValues.Thin;
            border.DiagonalBorder = new DiagonalBorder();
            borders.Append(border);
            borders.Count = UInt32Value.FromUInt32((uint)borders.ChildElements.Count);

            CellStyleFormats csfs = new CellStyleFormats();
            CellFormat cf = new CellFormat();
            cf.NumberFormatId = 0;
            cf.FontId = 0;
            cf.FillId = 0;
            cf.BorderId = 0;
            csfs.Append(cf);
            csfs.Count = UInt32Value.FromUInt32((uint)csfs.ChildElements.Count);

            uint iExcelIndex = 164;
            NumberingFormats nfs = new NumberingFormats();
            CellFormats cfs = new CellFormats();

            cf = new CellFormat();
            cf.NumberFormatId = 0;
            cf.FontId = 0;
            cf.FillId = 0;
            cf.BorderId = 0;
            cf.FormatId = 0;
            cfs.Append(cf);

            NumberingFormat nfDateTime = new NumberingFormat();
            nfDateTime.NumberFormatId = UInt32Value.FromUInt32(iExcelIndex++);
            nfDateTime.FormatCode = StringValue.FromString("dd/mm/yyyy hh:mm:ss");
            nfs.Append(nfDateTime);

            //NumberingFormat nf4decimal = new NumberingFormat();
            //nf4decimal.NumberFormatId = UInt32Value.FromUInt32(iExcelIndex++);
            //nf4decimal.FormatCode = StringValue.FromString("$#,##0.0000");
            //nfs.Append(nf4decimal);

            NumberingFormat nf4decimal = new NumberingFormat();
            nf4decimal.NumberFormatId = UInt32Value.FromUInt32(iExcelIndex++);
            nf4decimal.FormatCode = StringValue.FromString("#,#");
            nfs.Append(nf4decimal);

            // #,##0.00 is also Excel style index 4
            NumberingFormat nf2decimal = new NumberingFormat();
            nf2decimal.NumberFormatId = UInt32Value.FromUInt32(iExcelIndex++);
            nf2decimal.FormatCode = StringValue.FromString("$#,##0.00");
            nfs.Append(nf2decimal);

            // @ is also Excel style index 49
            NumberingFormat nfForcedText = new NumberingFormat();
            nfForcedText.NumberFormatId = UInt32Value.FromUInt32(iExcelIndex++);
            nfForcedText.FormatCode = StringValue.FromString("@");
            nfs.Append(nfForcedText);

            // index 1
            cf = new CellFormat();
            cf.NumberFormatId = nfDateTime.NumberFormatId;
            cf.FontId = 0;
            cf.FillId = 0;
            cf.BorderId = 0;
            cf.FormatId = 0;
            cf.ApplyNumberFormat = BooleanValue.FromBoolean(true);
            cfs.Append(cf);

            // index 2
            cf = new CellFormat();
            cf.NumberFormatId = nf4decimal.NumberFormatId;
            cf.FontId = 0;
            cf.FillId = 0;
            cf.BorderId = 0;
            cf.FormatId = 0;
            cf.ApplyNumberFormat = BooleanValue.FromBoolean(true);
            cfs.Append(cf);

            // index 3
            cf = new CellFormat();
            cf.NumberFormatId = nf2decimal.NumberFormatId;
            cf.FontId = 0;
            cf.FillId = 0;
            cf.BorderId = 0;
            cf.FormatId = 0;
            cf.ApplyNumberFormat = BooleanValue.FromBoolean(true);
            cfs.Append(cf);

            // index 4
            cf = new CellFormat();
            cf.NumberFormatId = nfForcedText.NumberFormatId;
            cf.FontId = 0;
            cf.FillId = 0;
            cf.BorderId = 0;
            cf.FormatId = 0;
            cf.ApplyNumberFormat = BooleanValue.FromBoolean(true);
            cfs.Append(cf);

            // index 5
            // Header text
            cf = new CellFormat();
            cf.NumberFormatId = nfForcedText.NumberFormatId;
            cf.FontId = 1;
            cf.FillId = 0;
            cf.BorderId = 0;
            cf.FormatId = 0;
            cf.ApplyNumberFormat = BooleanValue.FromBoolean(true);
            cfs.Append(cf);

            // index 6
            // column text
            cf = new CellFormat();
            cf.NumberFormatId = nfForcedText.NumberFormatId;
            cf.FontId = 1;
            cf.FillId = 0;
            cf.BorderId = 1;
            cf.FormatId = 0;
            cf.ApplyNumberFormat = BooleanValue.FromBoolean(true);
            cfs.Append(cf);

            // index 7
            // coloured 2 decimal text
            cf = new CellFormat();
            cf.NumberFormatId = nf2decimal.NumberFormatId;
            cf.FontId = 0;
            cf.FillId = 2;
            cf.BorderId = 0;
            cf.FormatId = 0;
            cf.ApplyNumberFormat = BooleanValue.FromBoolean(true);
            cfs.Append(cf);

            // index 8
            // coloured column text
            cf = new CellFormat();
            cf.NumberFormatId = nfForcedText.NumberFormatId;
            cf.FontId = 0;
            cf.FillId = 2;
            cf.BorderId = 1;
            cf.FormatId = 0;
            cf.ApplyNumberFormat = BooleanValue.FromBoolean(true);
            cfs.Append(cf);

            nfs.Count = UInt32Value.FromUInt32((uint)nfs.ChildElements.Count);
            cfs.Count = UInt32Value.FromUInt32((uint)cfs.ChildElements.Count);

            ss.Append(nfs);
            ss.Append(fts);
            ss.Append(fills);
            ss.Append(borders);
            ss.Append(csfs);
            ss.Append(cfs);

            CellStyles css = new CellStyles();
            CellStyle cs = new CellStyle();
            cs.Name = StringValue.FromString("Normal");
            cs.FormatId = 0;
            cs.BuiltinId = 0;            
            css.Append(cs);
            css.Count = UInt32Value.FromUInt32((uint)css.ChildElements.Count);
            ss.Append(css);

            DifferentialFormats dfs = new DifferentialFormats();
            dfs.Count = 0;
            ss.Append(dfs);

            TableStyles tss = new TableStyles();
            tss.Count = 0;
            tss.DefaultTableStyle = StringValue.FromString("TableStyleMedium9");
            tss.DefaultPivotStyle = StringValue.FromString("PivotStyleLight16");
            ss.Append(tss);

            return ss;
        }

        #endregion

        #region Cons-77

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="filename"></param>
        /// <param name="Response"></param>
        /// <returns></returns>
        public static MemoryStream CreateExcelDocumentAsStream_ReturnStream(DataSet dataset, string filename, System.Web.HttpResponse Response)
        {
            try
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook, true))
                {
                    WriteExcelFile(dataset, document);
                }
                stream.Flush();
                stream.Position = 0;

                return stream;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return null;
            }
        }

        #endregion
    }
}

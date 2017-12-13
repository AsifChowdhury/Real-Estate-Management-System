using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace CRUFLFormatAsBDT
{
    [ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("6F90E1C6-53D0-4B19-9D32-88162A77C598")]
    public interface IFormatAsBDCurrency
    {
        string AmountInWords(decimal amount);
    }
}

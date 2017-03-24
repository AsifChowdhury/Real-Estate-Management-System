using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RealEstateManagementSystem.UserInterface.Root
{
    public partial class frmSandBox : Form
    {
        public frmSandBox()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string weburl = "http://api.openweathermap.org/data/2.5/weather?q=" + textBox1.Text + "&mode=xml";

            var xml = await new WebClient().DownloadStringTaskAsync(new Uri(weburl));

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
            double temp = double.Parse(szTemp) - 273.16;
            textBox2.Text = temp.ToString("N2") + " Celcius";
        }
    }
}

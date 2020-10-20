using System;
using System.Windows.Forms;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            var userName = Environment.UserName;
            var factura = new Factura(@"C:\Users\" + userName + @"\Documents\Factura_Electronica.xml");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GeneradorDeReportesdeFacturas
{
    public partial class Main : Form
    {
        private List<Factura> facturas;
        private double Total;
        public Main()
        {
            InitializeComponent();
            facturas = new List<Factura>();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            var userName = Environment.UserName;
            var programDirectory = Directory.GetCurrentDirectory();
            Total = 0;
            //var directory = @"C:\Users\" + userName + @"\Documents\ControlE\facturas\FACTURAS Y SOLICITUDES QUERETARO 2019\reporte viaticos 2018-04-29";
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog()
            {
                SelectedPath = programDirectory
            };
            folderBrowser.ShowDialog();
            DirectoryInfo directory1 = new DirectoryInfo(folderBrowser.SelectedPath);
            //Console.WriteLine(directory);
            foreach (var file in directory1.GetFiles())
            {
                if (file.Extension == ".xml")
                {
                    facturas.Add(new Factura(file.FullName));
                    var facturaActual = facturas[facturas.Count - 1].Comprobante;
                    Console.WriteLine($"fecha:{facturaActual.Fecha}concepto:{facturaActual.Conceptos.DescripcionLongString}descripcion:" +
                        $"{facturaActual.Emisor.Nombre}total={facturaActual.Total}");
                    Total += facturaActual.Total;
                }

            }
            Console.WriteLine("Total de Reporte = " + Total);
            Console.ReadLine();
            //var factura = new Factura(@"C:\Users\" + userName + @"\Documents\Factura_Electronica.xml");

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

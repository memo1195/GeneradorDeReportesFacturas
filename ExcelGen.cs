using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace GeneradorDeReportesdeFacturas
{
    public class ExcelGen
    {
        private DirectoryInfo _directory;

        public double Total { get; private set; }
        public ExcelGen(DirectoryInfo directory)
        {
            _directory = directory;
            Total = 0;
            Action();
        }

        private void Action()
        {

            var wb = new XLWorkbook();
            foreach (var file in _directory.GetFiles())
            {
                if (file.Extension == ".xml")
                {
                    //facturas.Add(new Factura(file.FullName));

                    //var facturaActual = facturas[facturas.Count - 1].Comprobante;
                    var facturaActual = new Factura(file.FullName).Comprobante;

                    Console.WriteLine($"fecha:{facturaActual.Fecha}concepto:{facturaActual.Conceptos[0].Descripcion}descripcion:" +
                        $"{facturaActual.Emisor.Nombre}total={facturaActual.Total}");
                    Total += facturaActual.Total;
                }

            }
        }
    }
}

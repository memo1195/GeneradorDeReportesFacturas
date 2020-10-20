using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Factura
    {
        public static string ComprobanteTx
        {
            get
            {
                return "Comprobante";
            }
        }
        public static string EmisorTx
        {
            get
            {
                return "Emisor";
            }
        }
        private static string ReceptorTx
        {
            get
            {
                return "Receptor";
            }
        }
        private static string ConceptosTx
        {
            get
            {
                return "Conceptos";
            }
        }
        private static string ImpuestosTx
        {
            get
            {
                return "Impuestos";
            }
        }
        private static string ComplementoTx
        {
            get
            {
                return "Complemento";
            }
        }
        private static string AddendaTx
        {
            get
            {
                return "Addenda";
            }
        }
        private static string CfdiTx
        {
            get
            {
                return "cfdi:";
            }
        }
        private Comprobante comprobante;
        
        public Factura(string direccion)
        {
            LeerFactura(direccion);
        }

        private void LeerFactura(string direccion)
        {
            var doc = new XmlDocument();
            doc.Load(direccion);
            comprobante = new Comprobante(doc.LastChild);
        }
    }
}

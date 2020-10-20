using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Impuestos : ComponentXML
    {
        public double TotalImpuestosTrasladados
        {
            get
            {
                return Double.Parse(_attributes["TotalImpuestosTrasladados"]);
            }
        }
        public Traslados Traslados { get; }

        public Impuestos(XmlNode xmlNode)
            :base(xmlNode)
        {
            Traslados = new Traslados(xmlNode.FirstChild);
        }
    }
}

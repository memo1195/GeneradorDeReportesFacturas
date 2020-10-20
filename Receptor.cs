using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Receptor : ComponentXML
    {
        public string Rfc
        {
            get
            {
                return _attributes["Rfc"];
            }
        }
        public string UsoCFDI
        {
            get
            {
                return _attributes["UsoCFDI"];
            }
        }
        public string Nombre
        {
            get
            {
                return _attributes["Nombre"];
            }
        }

        public Receptor(XmlNode xmlNode)
            : base(xmlNode)
        {

        }
    }
}

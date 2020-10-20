using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Emisor : ComponentXML
    {
        public string Rfc
        {
            get
            {
                return _attributes["Rfc"];
            }
        }
        public string RegimenFiscal
        {
            get
            {
                return _attributes["RegimenFiscal"];
            }
        }
        public string Nombre
        {
            get
            {
                return _attributes["Nombre"];
            }
        }
        public Emisor(XmlNode xmlNode)
            :base(xmlNode)
        {

        }
    }
}

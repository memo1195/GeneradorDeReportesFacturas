using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Complemento:ComponentXML
    {
        TimbreFiscalDigital TimbreFiscalDigital { get; }

        public Complemento(XmlNode xmlNode)
            :base(xmlNode)
        {
            TimbreFiscalDigital = new TimbreFiscalDigital(xmlNode.FirstChild);
        }
    }
}

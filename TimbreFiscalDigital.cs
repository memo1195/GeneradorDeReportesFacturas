using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class TimbreFiscalDigital : ComponentXML
    {
        public string Version
        {
            get
            {
                return _attributes["Version"];
            }
        }
        public string SchemaLocation
        {
            get
            {
                return _attributes["SchemaLocation"];
            }
        }
        public string SelloSAT
        {
            get
            {
                return _attributes["SelloSAT"];
            }
        }
        public string FechaTimbrado
        {
            get
            {
                return _attributes["FechaTimbrado"];
            }
        }
        public string UUID
        {
            get
            {
                return _attributes["UUID"];
            }
        }
        public string RfcProvCertif
        {
            get
            {
                return _attributes["RfcProvCertif"];
            }
        }
        public string NoCertificadoSAT
        {
            get
            {
                return _attributes["NoCertificadoSAT"];
            }
        }
        public string SelloCFD
        {
            get
            {
                return _attributes["SelloCFD"];
            }
        }
        public string tfd
        {
            get
            {
                return _attributes["xmlns:tfd"];
            }
        }

        public TimbreFiscalDigital(XmlNode xmlNode)
            :base(xmlNode)
        {

        }
    }
}

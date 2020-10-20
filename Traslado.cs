using System;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Traslado : ComponentXML
    {
        public double Importe
        {
            get
            {
                return Double.Parse(_attributes["Importe"]);
            }
        }
        public double TasaOCuota
        {
            get
            {
                return Double.Parse(_attributes["TasaOCuota"]);
            }
        }
        public string TipoFactor
        {
            get
            {
                return _attributes["TipoFactor"];
            }
        }
        public string Impuesto
        {
            get
            {
                return _attributes["Impuesto"];
            }
        }
        public double Base
        {
            get
            {
                return Double.Parse(_attributes["Base"]);
            }
        }
        public string CodigoMultiple
        {
            get
            {
                return _attributes["CodigoMultiple"];
            }
        }

        public Traslado(XmlNode xmlNode)
            :base(xmlNode)
        {

        }

    }
}

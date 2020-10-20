using System.Xml;
using System;

namespace GeneradorDeReportesdeFacturas
{
    public class Concepto : ComponentXML
    {
        public string Cantidad
        {
            get
            {
                return _attributes["Cantidad"];
            }
        }
        public string ClaveProdServ
        {
            get
            {
                return _attributes["ClaveProdServ"];
            }
        }
        public string ClaveUnidad
        {
            get
            {
                return _attributes["ClaveUnidad"];
            }
        }
        public string Descripcion
        {
            get
            {
                return _attributes["Descripcion"];
            }
        }
        public double Importe
        {
            get
            {
                return Double.Parse(_attributes["Importe"]);
            }
        }
        public string Unidad
        {
            get
            {
                return _attributes["Unidad"];
            }
        }
        public double ValorUnitario
        {
            get
            {
                return Double.Parse(_attributes["ValorUnitario"]);
            }
        }

        public Concepto(XmlNode xmlNode):
            base(xmlNode)
        {
        }
    }
}

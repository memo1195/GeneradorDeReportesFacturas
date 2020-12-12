using System.Xml;
using System;

namespace GeneradorDeReportesdeFacturas
{
    public class Comprobante : ComponentXML
    {
        private const string _emisor = "Emisor";
        private const string _receptor = "Receptor";
        private const string _conceptos = "Conceptos";
        private const string _impuestos = "Impuestos";
        private const string _complemento = "Complemento";
        private const string _addenda = "Addenda";
        private const string _cfdi = "cfdi:";
        
        public string CFDI
        {
            get
            {
                return _attributes["xmlns:cfdi"];
            }
        }
        public string Certificado
        {
            get
            {
                return _attributes["Certificado"];
            }
        }
        public DateTime Fecha
        {
            get
            {
                var fecha = _attributes["Fecha"];
                return StringToDateTime(fecha.Substring(0, fecha.IndexOf('T')));
            }
        }
        public string Folio
        {
            get
            {
                return _attributes["Folio"];
            }
        }
        public string FormaPago
        {
            get
            {
                return _attributes["FormaPago"];
            }
        }
        public string LugarExpedicion
        {
            get
            {
                return _attributes["LugarExpedicion"];
            }
        }
        public string MetodoPago
        {
            get
            {
                return _attributes["MetodoPago"];
            }
        }
        public string Moneda
        {
            get
            {
                return _attributes["Moneda"];
            }
        }
        public string NoCertificado
        {
            get
            {
                return _attributes["NoCertificado"];
            }
        }
        public string Sello
        {
            get
            {
                return _attributes["Sello"];
            }
        }
        public string Serie
        {
            get
            {
                return _attributes["Serie"];
            }
        }
        public double SubTotal
        {
            get
            {
                return Double.Parse(_attributes["SubTotal"]);
            }
        }
        public byte TipoCambio
        {
            get
            {
                return Byte.Parse(_attributes["TipoCambio"]);
            }
        }
        public string TipoDeComprobante
        {
            get
            {
                return _attributes["TipoDeComprobante"];
            }
        }
        public double Total
        {
            get
            {
                return Double.Parse(_attributes["Total"]);
            }
        }
        public string Version
        {
            get
            {
                return _attributes["Version"];
            }
        }



        public Emisor Emisor { get; }

        public Receptor Receptor { get; }

        public Conceptos Conceptos { get; }

        public Impuestos Impuestos { get; }

        public Complemento Complemento { get; }

        public Comprobante(XmlNode xmlNode)
            : base(xmlNode)
        {
            foreach (var child in _childNodes)
            {
                switch (child.LocalName)
                {
                    case _emisor:
                        Emisor = new Emisor(child);
                        break;
                    case _receptor:
                        Receptor = new Receptor(child);
                        break;
                    case _conceptos:
                        Conceptos = new Conceptos(child);
                        break;
                    case _impuestos:
                        Impuestos = new Impuestos(child);
                        break;
                    case _complemento:
                        Complemento = new Complemento(child);
                        break;
                }
            }
        }


    }
}

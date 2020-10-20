using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Traslados : ComponentXML
    {
        public int Count
        {
            get
            {
                return _traslados.Count;
            }
        }

        private List<Traslado> _traslados;

        public Traslados(int count)
        {
            _traslados = new List<Traslado>(count);
        }

        public Traslados(List<Traslado> traslados)
        {
            _traslados = new List<Traslado>();
            foreach (var traslado in traslados)
            {
                _traslados.Add(traslado);
            }
        }

        public Traslados(XmlNode xmlNode):
            base(xmlNode)
        {
            _traslados = new List<Traslado>();
            foreach (XmlNode traslados in xmlNode.ChildNodes)
            {
                _traslados.Add(new Traslado(traslados));
            }
        }

        public Traslado this[int i]
        {
            get
            {
                return _traslados[i];
            }
            set { }
        }
    }
}

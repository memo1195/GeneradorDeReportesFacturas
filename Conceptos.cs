using System.Collections.Generic;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Conceptos : ComponentXML
    {
        public int Count { 
            get
            {
                return _conceptos.Count;
            } 
        }

        private List<Concepto> _conceptos;

        public Conceptos(int count)
        {
            _conceptos = new List<Concepto>(count);
        }

        public Conceptos(List<Concepto> conceptos)
        {
            _conceptos = new List<Concepto>();
            foreach (var concepto in conceptos)
            {
                _conceptos.Add(concepto);
            }
        }
        public Conceptos(XmlNode xmlNode)
            :base(xmlNode)
        {
            _conceptos = new List<Concepto>();
            foreach (XmlNode concepto in xmlNode.ChildNodes)
            {
                _conceptos.Add(new Concepto(concepto));
            }
        }

        public Concepto this[int i]
        {
            get
            {
                return _conceptos[i];
            }
            set{}
        }
    }
}

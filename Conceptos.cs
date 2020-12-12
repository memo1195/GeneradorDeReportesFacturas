using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public class Conceptos : ComponentXML, IEnumerable
    {
        public int Count
        {
            get
            {
                return _conceptos.Count;
            }
        }

        public string DescripcionLongString
        {
            get
            {
                var outputString = "";
                _conceptos.ForEach(x => outputString += x.Descripcion + ", ");
                return outputString;
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
            : base(xmlNode)
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
        }

        public IEnumerator GetEnumerator()
        {
            return new ConceptosEnum(this);
        }



        class ConceptosEnum : IEnumerator
        {
            Conceptos parent;
            int position;

            public ConceptosEnum(Conceptos parent)
            {
                this.parent = parent;
                position = -1;
            }
            public object Current
            {
                get
                {
                    if (position == -1 ||
                        position == parent._conceptos.Count)
                    {
                        throw new InvalidOperationException();
                    }
                    var index = position;
                    index = index % parent._conceptos.Count;
                    return parent._conceptos[index];
                }
            }

            public bool MoveNext()
            {
                if (position != parent._conceptos.Count)
                {
                    position++;
                }
                return position < parent._conceptos.Count;
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}

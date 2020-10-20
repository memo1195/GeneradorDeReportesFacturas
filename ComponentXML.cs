using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneradorDeReportesdeFacturas
{
    public abstract class ComponentXML
    {
        protected Dictionary<string, string> _attributes;
        protected List<XmlNode> _childNodes;
        public bool HasChildren { get; private set; }
        public ComponentXML()
        {
            _attributes = new Dictionary<string, string>();
            _childNodes = new List<XmlNode>();
        }

        public ComponentXML(XmlNode xmlNode)
        {
            _attributes = new Dictionary<string, string>();
            _childNodes = new List<XmlNode>();
            HasChildren = xmlNode.HasChildNodes;
            if(xmlNode.Attributes!=null)
                foreach(XmlAttribute xmlAttribute in xmlNode.Attributes)
                {
                    _attributes.Add(xmlAttribute.Name, xmlAttribute.Value);
                }
            if (HasChildren)
                foreach(XmlNode child in xmlNode.ChildNodes)
                {
                    _childNodes.Add(child);
                }
        }

    }
}

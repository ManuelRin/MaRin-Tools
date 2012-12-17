using System.Xml.Schema;
using System.Xml.Serialization;

namespace PublishWeb.Models
{
    [XmlRoot(ElementName = "Tools", Namespace = "")]
    public class ToolList
    {
        [XmlElement("Tool")]
        public ToolEntry[] Tools { get; set; }
    }
}
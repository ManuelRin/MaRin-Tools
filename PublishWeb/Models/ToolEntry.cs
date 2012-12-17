using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PublishWeb.Models
{
    public class ToolEntry
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime LastChanged { get; set; }
        public string ArtifactLink { get; set; }
    }
}
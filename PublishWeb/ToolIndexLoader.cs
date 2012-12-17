using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using PublishWeb.Models;

namespace PublishWeb
{
    public class ToolIndexLoader
    {
        private ToolList _list;

        public ToolList GetToolList()
        {
            return _list;
        }

        public void Load(string indexXmlPath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof (ToolList));

            using (FileStream stream = File.OpenRead(indexXmlPath))
            {
                _list = (ToolList) xmlSerializer.Deserialize(stream);
            }
        }
    }
}
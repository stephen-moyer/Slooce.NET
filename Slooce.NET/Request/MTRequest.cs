using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET
{
    [XmlRoot("message")]
    public class MTRequest : BaseRequest
    {

        [XmlElement("content")]
        public string Content { get; set; }

    }
}

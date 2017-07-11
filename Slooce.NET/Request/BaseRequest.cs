using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET
{

    [XmlRoot("message")]
    public abstract class BaseRequest
    {

        [XmlAttribute("id")]
        public string MessageId { get; set; }

        [XmlElement("partnerpassword")]
        public string PartnerPassword { get; set; }
        
    }
}

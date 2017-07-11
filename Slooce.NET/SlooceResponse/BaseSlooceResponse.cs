using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.SlooceResponse
{

    /// <summary>
    /// Messages that Slooce POSTs back to our callback urls
    /// </summary>
    [XmlRoot("message")]
    public abstract class BaseSlooceResponse
    {

        [XmlElement("keyword")]
        public string Keyword { get; set; }

        [XmlElement("user")]
        public string User { get; set; }

    }

}

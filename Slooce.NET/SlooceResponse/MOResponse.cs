using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.SlooceResponse
{
    /// <summary>
    /// The callback message for a user(number) texting our shortcode that doesn't match a command
    /// </summary>
    [XmlRoot("message")]
    public class MOResponse : BaseSlooceResponse
    {

        /// <summary>
        /// The content of the text
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

    }
}

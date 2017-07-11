using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.SlooceResponse
{
    /// <summary>
    /// The callback message for a user(number) texting a command our shortcode
    /// </summary>
    [XmlRoot("message")]
    public class MOCommandResponse : BaseSlooceResponse
    {
        /// <summary>
        /// The command from the user(Q for quit, H for help, etc)
        /// </summary>
        [XmlElement("command")]
        public string Command { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.SlooceResponse
{

    /// <summary>
    /// Message sent to us when a user successfully registers(texts our shortcode after not being registered)
    /// </summary>
    [XmlRoot("message")]
    public class UserRegisteredResponse : BaseSlooceResponse
    {
    }
}

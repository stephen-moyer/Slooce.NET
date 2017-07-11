using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.Response
{

    [XmlRoot("response")]
    public class BaseResponse
    {

        /// <summary>
        /// The message id you passed to the request for this response.
        /// If you passed null it will be generated for you.
        /// </summary>
        public string MessageId { get; set; }

        [XmlAttribute("id")]
        public string Id { get; set; }

    }

}

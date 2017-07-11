using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.Response
{
    [XmlRoot("response")]
    public class UserUnregisterResponse : BaseResponse
    {

        /// <summary>
        /// The unregister result
        /// </summary>
        [XmlAttribute("result")]
        public UserUnregisterResponseResult Result { get; set; }

    }

    public enum UserUnregisterResponseResult
    {

        //wish c# let you inherit enums :/

        /// <summary>
        /// Message sent successfully
        /// </summary>
        [XmlEnum("ok")]
        Ok,

        /// <summary>
        /// Invalid stop request
        /// </summary>
        [XmlEnum("invalid stop request")]
        InvalidStopRequest,
        
        /// <summary>
        /// Unknown error occured
        /// </summary>
        [XmlEnum("unknown error")]
        UnknownError

    }
}

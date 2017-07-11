using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.Response
{

    /// <summary>
    /// Response from the slooce api when we send a text message to a user
    /// </summary>
    [XmlRoot("response")]
    public class MTResponse : BaseResponse
    {

        /// <summary>
        /// The send message result
        /// </summary>
        [XmlAttribute("result")]
        public MTResponseResult Result { get; set; }

    }

    public enum MTResponseResult
    {

        //wish c# let you inherit enums :/

        /// <summary>
        /// Message sent successfully
        /// </summary>
        [XmlEnum("ok")]
        Ok,
        
        /// <summary>
        /// Users session is invalid(wrong keyword)
        /// </summary>
        [XmlEnum("invalid mt request")]
        InvalidMtRequest,

        /// <summary>
        /// Unsupported operator
        /// </summary>
        [XmlEnum("unsupported operator")]
        UnknownOperator,

        /// <summary>
        /// Message was blank
        /// </summary>
        [XmlEnum("empty mt request")]
        EmptyMtRequest,

        /// <summary>
        /// Unknown error occured
        /// </summary>
        [XmlEnum("unknown error")]
        UnknownError

    }

}

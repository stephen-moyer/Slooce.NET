using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.Response
{

    [XmlRoot("response")]
    public class UserRegisterResponse : BaseResponse
    {

        /// <summary>
        /// The register result
        /// </summary>
        [XmlAttribute("result")]
        public UserRegisterResponseResult Result { get; set; }

    }

    public enum UserRegisterResponseResult
    {

        //wish c# let you inherit enums :/

        /// <summary>
        /// User is registered
        /// </summary>
        [XmlEnum("ok")]
        Ok,

        /// <summary>
        /// Operator is unsupported
        /// </summary>
        [XmlEnum("unsupported operator")]
        UnsupportedOperator,

        /// <summary>
        /// Phone number is invalid
        /// </summary>
        [XmlEnum("invalid phonenumber")]
        InvalidPhoneNumber,

        /// <summary>
        /// Keyword is invalid
        /// </summary>
        [XmlEnum("invalid keyword")]
        InvalidKeyword,

        /// <summary>
        /// Keyword is deactivated
        /// </summary>
        [XmlEnum("service deactivated")]
        ServiceDeactivated,

        /// <summary>
        /// Unknown operator
        /// </summary>
        [XmlEnum("unknown operator")]
        UnknownOperator,

        /// <summary>
        /// Unknown error occured
        /// </summary>
        [XmlEnum("unknown error")]
        UnknownError

    }
}

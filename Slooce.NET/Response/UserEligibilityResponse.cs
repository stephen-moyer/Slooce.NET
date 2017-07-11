using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.Response
{

    /// <summary>
    /// Response from the slooce api when we ask if a user is eligible for texting
    /// </summary>
    [XmlRoot("response")]
    public class UserEligibilityResponse : BaseResponse
    {

        /// <summary>
        /// The state of this user,  values include:
        [XmlAttribute("state")]
        public UserState State { get; set; }

        /// <summary>
        /// The eligibility of this user
        /// </summary>
        [XmlAttribute("result")]
        public UserEligibilityResponseResult Result { get; set; }

    }

    public enum UserEligibilityResponseResult
    {

        //wish c# let you inherit enums :/

        /// <summary>
        /// User number is supported
        /// </summary>
        [XmlEnum("supported")]
        Supported,

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

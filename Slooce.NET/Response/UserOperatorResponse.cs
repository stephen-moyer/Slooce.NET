using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Slooce.NET.Response
{

    /// <summary>
    /// Response we get when we ask what the operator for a number is.
    /// </summary>
    [XmlRoot("response")]
    public class UserOperatorResponse : BaseResponse
    {

        /// <summary>
        /// The operator of this user.
        /// </summary>
        [XmlAttribute("operator")]
        public Operator Operator { get; set; }

    }

}

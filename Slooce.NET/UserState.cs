using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Slooce.NET
{

    [Serializable]
    public enum UserState
    {

        /// <summary>
        /// User has never registered
        /// </summary>
        [XmlEnum("new")]
        New,
        /// <summary>
        /// User has registered
        /// </summary>
        [XmlEnum("started")]
        Started,
        /// <summary>
        /// User has unregistered
        /// </summary>
        [XmlEnum("stopped")]
        Stopped,

    }
}

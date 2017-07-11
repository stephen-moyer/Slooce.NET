using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Slooce.NET
{

    /// <summary>
    /// A cache for the different xml serializers
    /// </summary>
    public class XmlSerializerCache<T>
    {

        public static readonly XmlSerializer Serializer = new XmlSerializer(typeof(T));

    }
}

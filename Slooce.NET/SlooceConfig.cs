using System;
using System.Collections.Generic;
using System.Text;

namespace Slooce.NET
{
    public class SlooceConfig
    {

        /// <summary>
        /// The url of your slooce endpoint. Typically looks like
        /// http://sloocehost.sloocedomain:slooceport/spi/partnerid/user/keyword/action
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// The password for your slooce environment
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Creates a new slooce endpoint
        /// </summary>
        /// <param name="url">See <see cref="Url"/></param>
        /// <param name="password">See <see cref="Password"/></param>
        public SlooceConfig(string url, string password)
        {
            Url = url;
            Password = password;
        }
        
    }
}

using Slooce.NET.Response;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Slooce.NET
{
    public class SlooceApi : IDisposable
    {

        private const string XmlMediaType = "application/xml";

        private static readonly XmlSerializerNamespaces EmptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
        private static readonly XmlWriterSettings WriterSettings = new XmlWriterSettings
        {
            OmitXmlDeclaration = true
        };

        private Lazy<HttpClient> clientLazy;

        public SlooceConfig Config { get; }

        public HttpClient Client => clientLazy.Value;
        
        /// <summary>
        /// Creates an instance of the slooce api class. This class is thread safe(so share an instance).
        /// </summary>
        public SlooceApi(SlooceConfig config)
        {
            Config = config;
            ValidateConfig(Config);
            clientLazy = new Lazy<HttpClient>(InitClient);
        }


        /// <summary>
        /// Checks if the user is eligible to receive texts
        /// </summary>
        /// <param name="user">The user(phone number). Make sure it starts with the country code</param>
        /// <param name="keyword">The keyword to check against.</param>
        /// <param name="messageId">Your custom message id. Will be generated if null</param>
        /// <returns>The response from slooce</returns>
        public Task<UserEligibilityResponse> CheckUserEligibilityAsync(string user, string keyword, string messageId = null)
        {
            var request = GetMessage<UserEligibilityRequest>(messageId);
            return SendMessageAsync<UserEligibilityRequest, UserEligibilityResponse>(user, keyword, "messages/supported", request);
        }

        /// <summary>
        /// Registers a user to the keyword. Will send them a text
        /// </summary>
        /// <param name="user">The user(phone number). Make sure it starts with the country code</param>
        /// <param name="keyword">The keyword to register to.</param>
        /// <param name="messageId">Your custom message id. Will be generated if null</param>
        /// <returns>The response from slooce</returns>
        public Task<UserRegisterResponse> RegisterUserAsync(string user, string keyword, string messageId = null)
        {
            var request = GetMessage<EmptyRequest>(messageId);
            return SendMessageAsync<EmptyRequest, UserRegisterResponse>(user, keyword, "messages/start", request);
        }

        /// <summary>
        /// Unregisters a user from the keyword
        /// </summary>
        /// <param name="user">The user(phone number). Make sure it starts with the country code</param>
        /// <param name="keyword">The keyword to unregister from.</param>
        /// <param name="messageId">Your custom message id. Will be generated if null</param>
        /// <returns>The response from slooce</returns>
        public Task<UserUnregisterResponse> UnregisterUserAsync(string user, string keyword, string messageId = null)
        {
            var request = GetMessage<EmptyRequest>(messageId);
            return SendMessageAsync<EmptyRequest, UserUnregisterResponse>(user, keyword, "messages/stop", request);
        }

        /// <summary>
        /// Sends a mobile terminated message to the user
        /// </summary>
        /// <param name="user">The user(phone number). Make sure it starts with the country code</param>
        /// <param name="keyword">The keyword to send under</param>
        /// <param name="content">The content of the message</param>
        /// <param name="messageId">Your custom message id. Will be generated if null</param>
        /// <returns>The response from slooce</returns>
        public Task<MTResponse> SendMtMessageAsync(string user, string keyword, string content, string messageId = null)
        {
            var request = GetMessage<MTRequest>(messageId);
            request.Content = content;
            return SendMessageAsync<MTRequest, MTResponse>(user, keyword, "messages/mt", request);
        }

        /// <summary>
        /// Checks the users operator
        /// </summary>
        /// <param name="user">The user(phone number). Make sure it starts with the country code</param>
        /// <param name="messageId">Your custom message id. Will be generated if null</param>
        /// <returns>The response from slooce</returns>
        public Task<UserOperatorResponse> CheckOperatorAsync(string user, string messageId = null)
        {
            var request = GetMessage<EmptyRequest>(messageId);
            return SendMessageAsync<EmptyRequest, UserOperatorResponse>(user, null, "operator", request);
        }

        private void ValidateConfig(SlooceConfig config)
        {
            if (string.IsNullOrEmpty(config.Url))
            {
                throw new ArgumentNullException(nameof(config.Url), "Cannot be null");
            }
            if (string.IsNullOrEmpty(config.Password))
            {
                throw new ArgumentNullException(nameof(config.Password), "Cannot be null");
            }
        }

        private HttpClient InitClient()
        {
            var uri = new Uri(Config.Url);
            //http://www.nimaara.com/2016/11/01/beware-of-the-net-httpclient/
            var sp = ServicePointManager.FindServicePoint(uri);
            sp.ConnectionLeaseTimeout = 60 * 1000;
            return new HttpClient
            {
                BaseAddress = uri
            };
        }

        /// <summary>
        /// Sends the message
        /// </summary>
        /// <typeparam name="TRequest">Only here so we can access the XmlSerializerCache for the request type</typeparam>
        private async Task<TResponse> SendMessageAsync<TRequest, TResponse>(string user, string keyword, string action, TRequest message)
            where TRequest : BaseRequest
            where TResponse : BaseResponse
        {
            using (var stringWriter = new StringWriter())
            using (var xmlWriter = XmlWriter.Create(stringWriter, WriterSettings))
            {
                //serialize message and build content body
                var serializer = XmlSerializerCache<TRequest>.Serializer;
                serializer.Serialize(xmlWriter, message, EmptyNamespaces);
                var content = new StringContent(stringWriter.ToString(), Encoding.UTF8, XmlMediaType);

                string url = keyword == null ? $"{user}/{action}" : $"{user}/{keyword}/{action}";

                //send request
                var responseMessage = await Client.PostAsync(url, content).ConfigureAwait(false);
                var responseString = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                var reader = new StringReader(responseString);

                //deserialize and return
                var response = (TResponse) XmlSerializerCache<TResponse>.Serializer.Deserialize(reader);
                response.MessageId = message.MessageId;
                return response;
            }
        }
        
        private T GetMessage<T>(string messageId) where T : BaseRequest, new()
        {
            var message = FastActivator<T>.NewInstance();
            message.MessageId = messageId ?? Guid.NewGuid().ToString();
            message.PartnerPassword = Config.Password;
            return message;
        }

        public void Dispose()
        {
            //if the lazy was never created then don't bother disposing
            if (clientLazy.IsValueCreated)
            {
                ((IDisposable)Client).Dispose();
            }
        }
    }
}

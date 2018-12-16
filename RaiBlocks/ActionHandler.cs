using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RaiBlocks
{
    public class ActionHandler<TAction, TResult> : IActionHandler<IAction<TResult>, TResult>
            where TAction : class, IAction<TResult>
            where TResult : class, IActionResult
    {
        private Uri _node;

        public ActionHandler(Uri node)
        {
            _node = node ?? throw new ArgumentNullException(nameof(node));
        }

        public async Task<TResult> Handle(IAction<TResult> action)
        {
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            var stringPayload = await Task.Run(() => JsonConvert.SerializeObject(action, Formatting.None, jsonSerializerSettings));
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync(_node.AbsoluteUri, httpContent);

                if (httpResponse.Content != null)
                {
                    var responseContent = await httpResponse.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<TResult>(responseContent);
                }
            }

            throw new Exception("No response.");
        }
    }
}

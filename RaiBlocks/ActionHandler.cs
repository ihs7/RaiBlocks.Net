using Newtonsoft.Json;
using RaiBlocks.Interfaces;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RaiBlocks
{
    public class ActionHandler<TAction, TResult> : IActionHandler<TAction, TResult>
            where TAction : IAction<TResult>
            where TResult : class
    {
        private Uri _node;

        public ActionHandler(Uri node)
        {
            _node = node ?? throw new ArgumentNullException(nameof(node));
        }

        public async Task<TResult> Handle(TAction action)
        {
            var stringPayload = await Task.Run(() => JsonConvert.SerializeObject(action));
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

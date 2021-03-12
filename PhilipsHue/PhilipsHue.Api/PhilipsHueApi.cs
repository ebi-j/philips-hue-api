using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PhilipsHue.Api.Domain;
using PhilipsHue.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PhilipsHue.Api
{
    public class PhilipsHueApi
    {
        private readonly string url;
        private readonly string username;
        private readonly IHttpClientFactory httpClientFactory;

        public PhilipsHueApi(string url, string username, IHttpClientFactory httpClientFactory)
        {
            this.url = url;
            this.username = username;
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Light>> GetAllLightsAynsc(CancellationToken cancellationToken)
        {
            var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync($"{url}/api/{username}/lights", cancellationToken);
            response.EnsureSuccessStatusCode();

            var lightsDictionary = JsonConvert.DeserializeObject<Dictionary<string, LightDto>>(await response.Content.ReadAsStringAsync(cancellationToken));

            return lightsDictionary.Select(d => d.Value.ToLight(Convert.ToInt32(d.Key)));
        }

        public async Task<IEnumerable<NewLight>> GetNewLightsAsync(CancellationToken cancellationToken)
        {
            var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync($"{url}/api/{username}/lights/new", cancellationToken);
            response.EnsureSuccessStatusCode();

            var newLightsResult = JsonConvert.DeserializeObject<JObject>(await response.Content.ReadAsStringAsync(cancellationToken));

            var newLights = new List<NewLight>();

            foreach(var obj in newLightsResult.Children())
            {
                if (int.TryParse(obj.Path, out var id))
                {
                    newLights.Add(JsonConvert.DeserializeObject<NewLightDto>(obj.First().ToString()).ToNewLight(id));
                }
            }

            return newLights;
        }

        public async Task SearchForNewLights(IEnumerable<string> serialNumbers, CancellationToken cancellationToken)
        {
            var client = httpClientFactory.CreateClient();
            HttpContent content = null;

            if (serialNumbers.Any())
            {
                content = new StringContent(JsonConvert.SerializeObject(serialNumbers), System.Text.Encoding.UTF8, "application/json");
            }

            await client.PostAsync($"{url}/api/{username}/lights", content, cancellationToken);
        }

        public async Task<Light> GetLightAsync(int id)
        {

        }
    }
}

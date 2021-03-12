using NUnit.Framework;
using PhilipsHue.Api.Domain;
using PhilipsHue.Api.Tests.Mock;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PhilipsHue.Api.Tests
{
    [TestFixture]
    public class Tests
    {
        private IHttpClientFactory httpClientFactory;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetAllLightsAynsc_WhenCalled_ReturnLightsAsync()
        {
            httpClientFactory = MockHttpClientFactory.Create(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(
                    @"{
                        ""1"": {
                                ""state"": {
                                    ""on"": false,
                                    ""bri"": 1,
                                    ""hue"": 33761,
                                    ""sat"": 254,
                                    ""effect"": ""none"",
                                    ""xy"": [
                                        0.3171,
                                        0.3366
                                    ],
                                    ""ct"": 159,
                                    ""alert"": ""none"",
                                    ""colormode"": ""xy"",
                                    ""mode"": ""homeautomation"",
                                    ""reachable"": true
                                },
                                ""swupdate"": {
                                    ""state"": ""noupdates"",
                                    ""lastinstall"": ""2018-01-02T19:24:20""
                                },
                                ""type"": ""Extended color light"",
                                ""name"": ""Hue color lamp 7"",
                                ""modelid"": ""LCT007"",
                                ""manufacturername"": ""Philips"",
                                ""productname"": ""Hue color lamp"",
                                ""capabilities"": {
                                    ""certified"": true,
                                    ""control"": {
                                        ""mindimlevel"": 5000,
                                        ""maxlumen"": 600,
                                        ""colorgamuttype"": ""B"",
                                        ""colorgamut"": [
                                            [
                                                0.675,
                                                0.322
                                            ],
                                            [
                                                0.409,
                                                0.518
                                            ],
                                            [
                                                0.167,
                                                0.04
                                            ]
                                        ],
                                        ""ct"": {
                                            ""min"": 153,
                                            ""max"": 500
                                        }
                                    },
                                    ""streaming"": {
                                        ""renderer"": true,
                                        ""proxy"": false
                                    }
                                },
                                ""config"": {
                                    ""archetype"": ""sultanbulb"",
                                    ""function"": ""mixed"",
                                    ""direction"": ""omnidirectional""
                                },
                                ""uniqueid"": ""00:17:88:01:00:bd:c7:b9-0b"",
                                ""swversion"": ""5.105.0.21169""
                            }
                        }"
                )
            });

            var api = new PhilipsHueApi("http://fake_url", "fake_username", httpClientFactory);

            var lights = await api.GetAllLightsAynsc(CancellationToken.None);

            Assert.That(lights.First().GetType() == typeof(Light));
        }

        [Test]
        public async Task GetNewLightsAsync_WhenCalled_ReturnNewLightsAsync()
        {
            httpClientFactory = MockHttpClientFactory.Create(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(
                    @"{
                        ""7"": {""name"": ""Hue Lamp 7""},
                        ""8"": {""name"": ""Hue Lamp 8""},
                        ""lastscan"": ""2012-10-29T12:00:00""
                    }"
                )
            });

            var api = new PhilipsHueApi("http://fake_url", "fake_username", httpClientFactory);

            var newLights = await api.GetNewLightsAsync(CancellationToken.None);

            Assert.That(newLights.First().GetType() == typeof(NewLight));
        }
    }
}
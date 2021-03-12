using Moq;
using Moq.Protected;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PhilipsHue.Api.Tests.Mock
{
    public static class MockHttpClientFactory
    {
        public static IHttpClientFactory Create(HttpResponseMessage responseMessage)
        {
            var mockFactory = new Mock<IHttpClientFactory>();
            var clientHandlerMock = new Mock<DelegatingHandler>();
            clientHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(responseMessage);

            var client = new HttpClient(clientHandlerMock.Object);

            mockFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(client);

            return mockFactory.Object;
        }
    }
}

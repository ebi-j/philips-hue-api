namespace PhilipsHue.Api.Domain
{
    public struct Streaming
    {
        public bool Renderer { get; private set; }
        public bool Proxy { get; private set; }

        public Streaming(bool renderer, bool proxy)
        {
            Renderer = renderer;
            Proxy = proxy;
        }
    }
}

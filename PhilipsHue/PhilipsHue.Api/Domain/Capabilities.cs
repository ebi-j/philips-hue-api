namespace PhilipsHue.Api.Domain
{
    public class Capabilities
    {
        public bool Certified { get; private set; }
        public Control Control { get; private set; }
        public Streaming Streaming { get; private set; }

        public Capabilities(bool certified, Control control, Streaming streaming)
        {
            Certified = certified;
            Control = control;
            Streaming = streaming;
        }
    }
}

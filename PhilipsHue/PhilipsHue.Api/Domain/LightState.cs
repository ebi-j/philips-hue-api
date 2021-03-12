namespace PhilipsHue.Api.Domain
{
    public class LightState
    {
        public bool On { get; private set; }
        public int Brightness { get; private set; }
        public int Hue { get; private set; }
        public int Saturation { get; private set; }
        public CIEColor CIEColor { get; private set; }
        public int ColorTemperature { get; private set; }
        public Alert Alert { get; private set; }
        public Effect Effect { get; private set; }
        public string ColorMode { get; private set; }
        public string Mode { get; private set; }
        public bool Reachable { get; private set; }

        public LightState(
            bool on,
            int brightness,
            int hue,
            int saturation,
            CIEColor cieColor,
            int colorTemperature,
            Alert alert,
            Effect effect,
            string colorMode,
            string mode,
            bool reachable)
        {
            On = on;
            Brightness = brightness;
            Hue = hue;
            Saturation = saturation;
            CIEColor = cieColor;
            ColorTemperature = colorTemperature;
            Alert = alert;
            Effect = effect;
            ColorMode = colorMode;
            Mode = mode;
            Reachable = reachable;
        }
    }
}

namespace PhilipsHue.Api.Domain
{
    public struct CIEColor
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public CIEColor(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}

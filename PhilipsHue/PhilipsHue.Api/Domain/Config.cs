namespace PhilipsHue.Api.Domain
{
    public struct Config
    {
        public string Archetype { get; private set; }
        public string Function { get; private set; }
        public string Direction { get; private set; }

        public Config(string archetype, string function, string direction)
        {
            Archetype = archetype;
            Function = function;
            Direction = direction;
        }
    }
}

namespace PhilipsHue.Api.Domain
{
    public struct NewLight
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public NewLight(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

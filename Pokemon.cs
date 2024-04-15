namespace poke_api
{
    public class Pokemon
    {
        public int Height { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} {Height}";
        }
    }
}

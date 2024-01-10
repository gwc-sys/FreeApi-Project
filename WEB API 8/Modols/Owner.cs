namespace WEB_API_8.Modols
{
    class Owner 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gym { get; set; }
        public Country Country { get; set; }
        public ICollection <PokemonOwner> PokemonOwners { get; set; }
    }
}
namespace WEB_API_8.Modols
{
    class PokemonOwner
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }    
        public Pokemon Pokemon { get; set; }
        public Owner  Owner { get; set; }
    }
}
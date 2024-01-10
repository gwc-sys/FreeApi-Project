namespace WEB_API_8.Modols
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection <PokemonCategory> PokemonCategories { get; set; }
    }
}
namespace WEB_API_8.Modols
{
     class Pokemon
    {
       
        public int id { get; set; }
        public string Name { get; set; }
       // public DateTime DateOfBrith { get; set; }

       public ICollection<Review> Reviews { get; set; }
       public  ICollection<PokemonOwner> PokemonOwners { get; set; }
       public   ICollection<PokemonCategory> PokemonCategories {  get; set; }
    }
}


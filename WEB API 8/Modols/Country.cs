namespace WEB_API_8.Modols
{
    class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection <Owner> Owners { get; set; }
    }
}
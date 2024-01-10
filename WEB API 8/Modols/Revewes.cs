namespace WEB_API_8.Modols
{
    class Reviewes
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        public ICollection<Review> Reviews { get; set; }       
    }
}
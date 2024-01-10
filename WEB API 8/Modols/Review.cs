namespace WEB_API_8.Modols
{
    class Review
    {
        public int Id { get; set; }
        public string  Title { get; set; }  
        public string Text { get; set; }   
        public Reviewes reviewes { get; set; }    
        public Pokemon pokemon { get; set; }      
    }
}   
namespace GraphqlDemo.Models
{
    public class Book
    {
        public string Id { get; set; }
        [UseSorting]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
    }
}

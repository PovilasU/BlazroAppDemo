namespace BlazorAppDemo.Models.Shared
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string AuthorUrl { get; set; } = string.Empty;
        public string Content { get; set; } 
        public string ContentUrl { get; set; } = string.Empty;
        
    }
}

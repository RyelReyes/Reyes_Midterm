namespace Reyes_MIdterm.DTO
{
    namespace CommunityLibraryAPI.DTOs;

    public class BookDto
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public string ISBN { get; set; } = "";
        public string Category { get; set; } = "";
        public int TotalCopies { get; set; }
    }
}

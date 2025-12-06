namespace Onion.WebApi.Models.ResponseModels.Books
{
    public class BookResponseModel
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}

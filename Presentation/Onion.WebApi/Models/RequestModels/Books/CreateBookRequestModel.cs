namespace Onion.WebApi.Models.RequestModels.Books
{
    public class CreateBookRequestModel
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}

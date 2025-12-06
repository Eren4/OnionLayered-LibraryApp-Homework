namespace Onion.WebApi.Models.RequestModels.Authors
{
    public class UpdateAuthorRequestModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Nationality { get; set; }
    }
}

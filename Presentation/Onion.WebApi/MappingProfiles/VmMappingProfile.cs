using AutoMapper;
using Onion.Application.DTOs;
using Onion.WebApi.Models.RequestModels.Authors;
using Onion.WebApi.Models.RequestModels.Books;
using Onion.WebApi.Models.ResponseModels.Authors;
using Onion.WebApi.Models.ResponseModels.Books;
using Onion.WebApi.Models.ResponseModels.Categories;
using Onion.WebApi.Models.ResponseModels.Tags;

namespace Onion.WebApi.MappingProfiles
{
    public class VmMappingProfile : Profile
    {
        public VmMappingProfile()
        {
            CreateMap<CreateCategoryRequestModel, CategoryDTO>();
            CreateMap<UpdateCategoryRequestModel, CategoryDTO>();
            CreateMap<CategoryDTO, CategoryResponseModel>();

            CreateMap<CreateAuthorRequestModel, AuthorDTO>();
            CreateMap<UpdateAuthorRequestModel, AuthorDTO>();
            CreateMap<AuthorDTO, AuthorResponseModel>();

            CreateMap<CreateBookRequestModel, BookDTO>();
            CreateMap<UpdateBookRequestModel, BookDTO>();
            CreateMap<BookDTO, BookResponseModel>();

            CreateMap<CreateTagRequestModel, TagDTO>();
            CreateMap<UpdateTagRequestModel, TagDTO>();
            CreateMap<TagDTO, TagResponseModel>();
        }
    }
}

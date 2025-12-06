using AutoMapper;
using Onion.Application.DTOs;
using Onion.Application.IManagers;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Models;

namespace Onion.InnerInfrastructure.ManagerConcretes
{
    public class CategoryManager : BaseManager<CategoryDTO, Category>, ICategoryManager
    {
        private readonly ICategoryRepository _repository;

        public CategoryManager(ICategoryRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}

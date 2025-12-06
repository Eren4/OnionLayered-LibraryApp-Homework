using AutoMapper;
using Onion.Application.DTOs;
using Onion.Application.IManagers;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Models;

namespace Onion.InnerInfrastructure.ManagerConcretes
{
    public class AuthorManager : BaseManager<AuthorDTO, Author>, IAuthorManager
    {
        private readonly IAuthorRepository _repository;

        public AuthorManager(IAuthorRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}

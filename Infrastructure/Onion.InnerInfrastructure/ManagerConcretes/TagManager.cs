using AutoMapper;
using Onion.Application.DTOs;
using Onion.Application.IManagers;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Models;
using Onion.InnerInfrastructure.ManagerConcretes;

namespace Project.BLL.Managers.Concretes
{
    public class TagManager : BaseManager<TagDTO, Tag>, ITagManager
    {
        private readonly ITagRepository _repository;

        public TagManager(ITagRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}

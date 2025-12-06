using AutoMapper;
using Onion.Application.DTOs;
using Onion.Application.IManagers;
using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Models;
using Onion.InnerInfrastructure.ManagerConcretes;

namespace Project.BLL.Managers.Concretes
{
    public class BookManager : BaseManager<BookDTO, Book>, IBookManager
    {
        private readonly IBookRepository _repository;

        public BookManager(IBookRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}

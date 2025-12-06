using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Models;
using Onion.Persistence.ContextClasses;

namespace Onion.Persistence.RepositoryConcretes
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(MyContext context) : base(context)
        {

        }
    }
}

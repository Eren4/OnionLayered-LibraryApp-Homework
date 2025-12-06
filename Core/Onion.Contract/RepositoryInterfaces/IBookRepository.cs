using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Domain.Models;

namespace Onion.Contract.RepositoryInterfaces
{
    public interface IBookRepository : IRepository<Book>
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Application.DTOs;
using Onion.Domain.Models;

namespace Onion.Application.IManagers
{
    public interface ICategoryManager : IManager<CategoryDTO, Category>
    {
    }
}

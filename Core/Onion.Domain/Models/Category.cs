using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        // Relational properties
        public virtual ICollection<Book> Books { get; set; }
    }
}

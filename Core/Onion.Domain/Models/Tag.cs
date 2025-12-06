using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

        // Relational properties
        public virtual ICollection<Book> Books { get; set; }
    }
}

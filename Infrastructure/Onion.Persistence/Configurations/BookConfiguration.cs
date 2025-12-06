using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Models;

namespace Onion.Persistence.Configurations
{
    public class BookConfiguration : BaseConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);

            builder
                .HasOne(b => b.Author)
                .WithMany(a => a.Books);

            builder
                .HasMany(b => b.Tags)
                .WithMany(t => t.Books);
        }
    }
}

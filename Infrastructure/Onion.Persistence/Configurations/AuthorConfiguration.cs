using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Models;

namespace Onion.Persistence.Configurations
{
    public class AuthorConfiguration : BaseConfiguration<Author>
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            base.Configure(builder);

            builder
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId).IsRequired();
        }
    }
}

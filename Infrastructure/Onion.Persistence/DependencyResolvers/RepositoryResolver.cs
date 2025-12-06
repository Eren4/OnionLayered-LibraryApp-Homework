using Microsoft.Extensions.DependencyInjection;
using Onion.Contract.RepositoryInterfaces;
using Onion.Persistence.RepositoryConcretes;

namespace Onion.Persistence.DependencyResolvers
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
        }
    }
}

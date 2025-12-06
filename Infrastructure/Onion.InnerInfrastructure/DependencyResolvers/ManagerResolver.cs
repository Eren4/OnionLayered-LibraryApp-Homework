using Microsoft.Extensions.DependencyInjection;
using Onion.Application.IManagers;
using Onion.InnerInfrastructure.ManagerConcretes;
using Project.BLL.Managers.Concretes;

namespace Onion.InnerInfrastructure.DependencyResolvers
{
    public static class ManagerResolver
    {
        public static void AddManagerService(this IServiceCollection services)
        {
            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<IBookManager, BookManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<ITagManager, TagManager>();
        }
    }
}

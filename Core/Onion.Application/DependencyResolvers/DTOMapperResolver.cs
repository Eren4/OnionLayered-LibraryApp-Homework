using Microsoft.Extensions.DependencyInjection;
using Onion.Application.MappingProfiles;

namespace Onion.Application.DependencyResolvers
{
    public static class DTOMapperResolver
    {
        public static void AddDTOMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DTOMappingProfile));
        }
    }
}

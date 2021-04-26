using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InveTime.DataBase.DLL
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesInDb(this IServiceCollection services) => services
            .AddTransient<IRepository<Employee>, DbRepository<Employee>>()
            .AddTransient<IRepository<Position>, DbRepository<Position>>()
            .AddTransient<IRepository<Product>, DbRepository<Product>>()
            .AddTransient<IRepository<TypeProduct>, DbRepository<TypeProduct>>()
            .AddTransient<IRepository<DateInventarisation>, DbRepository<DateInventarisation>>()
            ;
    }
}

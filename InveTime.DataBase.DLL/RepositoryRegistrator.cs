using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InveTime.DataBase.DLL
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesInDb(this IServiceCollection services) => services
            .AddTransient<IRepository<Employee>, EmployeeRepository>()
            .AddTransient<IRepository<Position>, DbRepository<Position>>()
            .AddTransient<IRepository<Product>, ProductRepository>()
            .AddTransient<IRepository<Category>, CategoryRepository>()
            .AddTransient<IRepository<DateInventarisation>, DbRepository<DateInventarisation>>()
            .AddTransient<IRepository<CategorySearching>, DbRepository<CategorySearching>>()
            ;
    }
}

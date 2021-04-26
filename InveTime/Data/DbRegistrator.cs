using InveTime.DataBase.DLL;
using InveTime.DataBase.DLL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InveTime.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) => services
            .AddDbContext<InveTimeDB>(opt =>
            {
                var type = Configuration["Type"];
                if (type == "MSSQL") opt.UseSqlServer(Configuration.GetConnectionString(type));
                else throw new InvalidOperationException($"Тип подключения {type} не поддерживается");
            })
            .AddTransient<DbInitializer>()
            .AddRepositoriesInDb()
            ;
    }
}

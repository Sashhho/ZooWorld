namespace ZooWorld.Infrastructures
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ZooWorld.Data;

    public static class ApplicationBuilderExtensions
    {
            public static IApplicationBuilder PrepreDatabase(this IApplicationBuilder app)
            {
                var scopedService = app.ApplicationServices.CreateScope();
                var data = scopedService.ServiceProvider.GetService<ZooWorldDbContext>();
                data.Database.Migrate();

                return app;
            }
    }
}

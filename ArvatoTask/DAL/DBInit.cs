using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ArvatoTask.DAL
{
    public static class DBInit
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<CurrencyContext>();

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var currency1 = new Currencies { Name = "USD", RateEuro = 1.218895, Date = "2021-01-13" };

                context.Currencies.Add(currency1);

                context.SaveChanges();

            }
        }

    }
}

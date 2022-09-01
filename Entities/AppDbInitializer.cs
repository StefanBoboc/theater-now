using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheaterNow.Entities
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Clients.Any())
                {
                    context.Clients.AddRange(
                    new Client()
                    {
                        FirstName = "Alex",
                        LastName = "Mocanu",
                        Email = "alex.mocanu@yahoo.com",
                        BirthDate = DateTime.Now.AddDays(-10)
                    },
                    new Client()
                    {
                        FirstName = "Maria",
                        LastName = "Lulea",
                        Email = "maria.lulea@gmail.com",
                        BirthDate = DateTime.Now.AddDays(-5)
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOU.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IOU.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IOUContext(
                serviceProvider.GetRequiredService<DbContextOptions<IOUContext>>()))
            {
                if (!context.User.Any())
                {

                    context.User.AddRange(
                        new User
                        {
                            userName = "abc",
                            password = "123",
                            userType = (userTypeEnum) 0
                        },
                        new User
                        {
                            userName = "a",
                            password = "a",
                            userType = (userTypeEnum) 1
                        }


                    );
                    context.SaveChanges();


                }

                if(!context.IOUSlip.Any())
                {

                    context.IOUSlip.AddRange(
                        new IOUSlip
                        {
                            Owner = "a",
                            Debtor = "Jesse",
                            Amount = 10
                        },
                        new IOUSlip
                        {
                            Owner = "a",
                            Debtor = "Candice",
                            Amount = -10.5M
                        }


                    );
                    context.SaveChanges();


                }


            }







        }
    }
}

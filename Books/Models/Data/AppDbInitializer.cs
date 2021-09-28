using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //using(var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            //{
             //   var context = servicescope.ServiceProvider.GetService<AppDbContext>();
               // if (!context.Books.Any())
               // {
                   // context.Books.AddRange(new Book()
                   // {
                   //     Title = "1st Book Title",
                     //   Description = "1st Book description",
                     //   IsRead = true,
                     //   DateRead = DateTime.Now.AddDays(-10),
                     //   Rate = 4,
                     //   Genre = "Biography",
                      //  Author = "First Author",
                      //  CoverUrl = "https....",
                      //  DateAdded = DateTime.Now


                   // },
                   // new Book()
                   // {
                    //    Title = "2nd Book Title",
                    //    Description = "2nd Book description",
                   //     IsRead = false,
                   //     Genre = "Biography",
                   //     Author = "First Author",
                   //     CoverUrl = "https....",
                    //    DateAdded = DateTime.Now


                  //  }
                  //  );
                   // context.SaveChanges();
               // }
           // }
        }
    }
}

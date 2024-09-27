using Microsoft.EntityFrameworkCore;
using WebMVC_2.Data;

namespace WebMVC_2.Models
{
    public class InitialClass
    {
        public static void Initialize(DBContext context)
        {
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return; // DB has been seeded
                }

                context.Auth.AddRange(
                    new Auth
                    {
                        Name = "Стендаль"
                    },
                    new Auth
                    {
                        Name = "Бджілка"
                    },
                    new Auth
                    {
                        Name = "Брауде"
                    },
                    new Auth
                    {
                        Name = "Саймак"
                    });
                context.SaveChanges();

                context.Publisher.AddRange(
                    new Publisher
                    {
                        Name = "Старий Львів",
                        Country = "Україна"
                    },
                    new Publisher
                    {
                        Name = "Фантастика",
                        Country = "Україна"
                    },
                    new Publisher
                    {
                        Name = "Bhv",
                        Country = "Україна"
                    }
                );
                context.SaveChanges();

                context.Book.AddRange(
                    new Book
                    {
                        Title = "Червоне та чорне",
                        ReleaseDate = 1989,
                        Author = context.Auth.FirstOrDefault(x => x.Name == "Стендаль"),
                        Publisher = context.Publisher.First(x => x.Name == "Старий Львів"),
                        AgeCategory = 16,
                    },
                    new Book
                    {
                        Title = "Місто",
                        ReleaseDate = 1985,
                        Author = context.Auth.FirstOrDefault(x => x.Name == "Саймак"),
                        Publisher = context.Publisher.First(x => x.Name == "Фантастика"),
                        AgeCategory = 12,
                    },
                    new Book
                    {
                        Title = "Казки",
                        ReleaseDate = 2015,
                        Author = context.Auth.FirstOrDefault(x => x.Name == "Бджілка"),
                        Publisher = context.Publisher.First(x => x.Name == "Bhv"),
                        AgeCategory = 2,
                    },
                    new Book
                    {
                        Title = "Технологія разработки программного забезпечення",
                        ReleaseDate = 2004,
                        Author = context.Auth.FirstOrDefault(x => x.Name == "Брауде"),
                        Publisher = context.Publisher.First(x => x.Name == "Харків"),
                        AgeCategory = 8,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
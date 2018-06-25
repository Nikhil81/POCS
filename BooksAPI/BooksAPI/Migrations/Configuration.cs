namespace BooksAPI.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksAPI.Models.BooksAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BooksAPI.Models.BooksAPIContext context)
        {
            context.Authors.AddOrUpdate(new Author[] {
                new Author() { AuthorID = 1, Name = "Ralls, Kim" },
                new Author() { AuthorID = 2, Name = "Corets, Eva" },
                new Author() { AuthorID = 3, Name = "Randall, Cynthia" },
                new Author() { AuthorID = 4, Name = "Thurman, Paula" }
            });

            context.Books.AddOrUpdate(new Book[] {
                new Book() { BookID = 1,  Title= "Midnight Rain", Genre = "Fantasy", PublishDate = new DateTime(2000, 12, 16), AuthorID = 1, Description ="A former architect battles an evil sorceress.", Price = 14.95M },
                new Book() { BookID = 2, Title = "Maeve Ascendant", Genre = "Fantasy",PublishDate = new DateTime(2000, 11, 17), AuthorID = 2, Description ="After the collapse of a nanotechnology society, the young" +"survivors lay the foundation for a new society.", Price = 12.95M },
                new Book() { BookID = 3, Title = "The Sundered Grail", Genre = "Fantasy",PublishDate = new DateTime(2001, 09, 10), AuthorID = 2, Description ="The two daughters of Maeve battle for control of England.", Price = 12.95M },
                new Book() { BookID = 4, Title = "Lover Birds", Genre = "Romance",PublishDate = new DateTime(2000, 09, 02), AuthorID = 3, Description ="When Carla meets Paul at an ornithology conference, tempers fly.", Price = 7.99M },
                new Book() { BookID = 5, Title = "Splish Splash", Genre = "Romance",PublishDate = new DateTime(2000, 11, 02), AuthorID = 4, Description ="A deep sea diver finds true love 20,000 leagues beneath the sea.", Price = 6.99M},
            });


        }
    }
}

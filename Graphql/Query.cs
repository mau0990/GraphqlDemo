using GraphqlDemo.Models;

namespace GraphqlDemo.Graphql
{
    public class Query
    {
        public IEnumerable<Book> GetBooks() => new List<Book>
        {
           new Book { Id = "1", Title = "Book One", Author = "Author A", Genre = "Fiction", Description = "A fascinating tale.", Publisher = "Publisher X", PublishedDate = "2023-01-01" },
           new Book { Id = "2", Title = "Book Two", Author = "Author B", Genre = "Non-Fiction", Description = "An insightful read.", Publisher = "Publisher Y", PublishedDate = "2022-05-15" },
           new Book { Id = "3", Title = "Book Three", Author = "Author C", Genre = "Science Fiction", Description = "A journey through space.", Publisher = "Publisher Z", PublishedDate = "2021-08-10" },
           new Book { Id = "4", Title = "Book Four", Author = "Author D", Genre = "Fantasy", Description = "A magical adventure.", Publisher = "Publisher W", PublishedDate = "2020-11-20" },
           new Book { Id = "5", Title = "Book Five", Author = "Author E", Genre = "Mystery", Description = "A thrilling mystery.", Publisher = "Publisher V", PublishedDate = "2019-03-30" },
           new Book { Id = "6", Title = "Book Six", Author = "Author F", Genre = "Romance", Description = "A heartwarming story.", Publisher = "Publisher U", PublishedDate = "2018-07-25" },
           new Book { Id = "7", Title = "Book Seven", Author = "Author G", Genre = "Horror", Description = "A spine-chilling tale.", Publisher = "Publisher T", PublishedDate = "2017-10-31" },
           new Book { Id = "8", Title = "Book Eight", Author = "Author H", Genre = "Biography", Description = "An inspiring life story.", Publisher = "Publisher S", PublishedDate = "2016-12-12" },
           new Book { Id = "9", Title = "Book Nine", Author = "Author I", Genre = "Historical Fiction", Description = "A glimpse into the past.", Publisher = "Publisher R", PublishedDate = "2015-04-18" },
           new Book { Id = "10", Title = "Book Ten", Author = "Author J", Genre = "Thriller", Description = "An edge-of-your-seat thriller.", Publisher = "Publisher Q", PublishedDate = "2014-09-05" }
        };
    }
}

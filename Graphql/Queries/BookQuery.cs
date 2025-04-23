using GraphqlDemo.DBAccess;
using GraphqlDemo.Models;

namespace GraphqlDemo.Graphql.Queries
{
    public class BookQuery
    {
        [UseFiltering]
        [UseSorting]
        public IQueryable<Book> GetBooks( AppDbContext context) => context.Books;

        //[UseProjection]
        //[UseFiltering]
        //[UseSorting]
        //public IQueryable<Book> GetBooks([Service] AppDbContext context) => context.Books;
    }
}

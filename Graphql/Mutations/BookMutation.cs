using GraphqlDemo.DBAccess;
using GraphqlDemo.Graphql.Inputs;
using GraphqlDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphqlDemo.Graphql.Mutations
{
    public class BookMutation
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public BookMutation(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<Book> AddBookAsync(BookInput input)
        {
            await using var dbContext = await _contextFactory.CreateDbContextAsync();

            var book = new Book
            {
                Author = input.Author,
                Description = input.Description,
                Genre = input.Genre,
                Publisher = input.Publisher,
                PublishedDate = input.PublishedDate,
                Title = input.Title
            };
            dbContext.Books.Add(book);
            await dbContext.SaveChangesAsync();

            return book;
        }
    }
}

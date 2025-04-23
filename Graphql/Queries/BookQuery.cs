using GraphqlDemo.DBAccess;
using GraphqlDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphqlDemo.Graphql.Queries
{
    public class BookQuery
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public BookQuery(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        [UseFiltering]
        [UseSorting]
        public async Task<List<Book>> GetBooks()
        {
            await using var dbContext = await _contextFactory.CreateDbContextAsync();
            return await dbContext.Books.ToListAsync();
        }
    }
}

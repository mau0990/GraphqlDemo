using GraphqlDemo.DBAccess;
using GraphqlDemo.Graphql.Queries;
using HotChocolate.AspNetCore.Voyager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<BookQuery>()
    .RegisterDbContextFactory<AppDbContext>()
    .AddFiltering()
    .AddSorting();


var app  = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGraphQL();
app.UseVoyager("/graphql", "/graphql-voyager");
app.Run();
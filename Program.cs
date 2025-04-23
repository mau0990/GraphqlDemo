using GraphqlDemo.Graphql;
using HotChocolate.AspNetCore.Voyager;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();


var app  = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Add this line
}

app.MapGraphQL();

app.UseVoyager("/graphql", "/graphql-voyager");
app.Run();
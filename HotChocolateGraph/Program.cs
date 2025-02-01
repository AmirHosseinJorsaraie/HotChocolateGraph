using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Query;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddGraphQLServer()
    .AddQueryType(t=> t.Name("Query"))
    .AddType<PersonQuery>()
    .AddType<CourseQuery>();

var app = builder.Build();

app.MapGraphQL();

app.Run();

using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Mutation;
using HotChocolateGraph.Query;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IPersonRepository, PersonRepository>();
builder.Services.AddSingleton<ICourseRepository, CourseRepository>();
builder.Services.AddGraphQLServer()
    .AddQueryType(t => t.Name("Query"))
    .AddMutationType(t=>t.Name("Mutation"))
    .AddTypeExtension<PersonQuery>()
    .AddTypeExtension<CourseQuery>()
    .AddTypeExtension<PersonMutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();

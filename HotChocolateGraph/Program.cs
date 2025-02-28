using HotChocolateGraph.ApiRepository;
using HotChocolateGraph.Mutation;
using HotChocolateGraph.Query;
using HotChocolateGraph.Subscription;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IPersonRepository, PersonRepository>();
builder.Services.AddSingleton<ICourseRepository, CourseRepository>();
builder.Services.AddGraphQLServer()
    .AddQueryType(t => t.Name("Query"))
    .AddMutationType(t => t.Name("Mutation"))
    .AddSubscriptionType(t => t.Name("Subscription"))
    .AddTypeExtension<PersonQuery>()
    .AddTypeExtension<CourseQuery>()
    .AddTypeExtension<PersonSubscription>()
    .AddTypeExtension<CourseSubscription>()
    .AddTypeExtension<PersonMutation>()
    .AddTypeExtension<CourseMutation>()
    .AddInMemorySubscriptions();


var app = builder.Build();

app.MapGraphQL();

app.UseWebSockets();

app.Run();

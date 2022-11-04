using MeetupMaker.Application;
using MeetupMaker.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    //adding application and infrastructure services
    //for more source code lookup DependencyInjection.cs in each project
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure();

    builder.Services.AddControllers();
}
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

using Microsoft.AspNetCore.Routing.Constraints;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movie}/{action=Index}/{id:int?}/{name:alpha?}"
                //,defaults: new {Controller = "Movie", Action = "GetMovie"}
                //,constraints: new {id = new IntRouteConstraint()}
                );

            app.Run();
        }
    }
}

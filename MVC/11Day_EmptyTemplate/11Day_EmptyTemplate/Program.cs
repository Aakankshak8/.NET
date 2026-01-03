namespace _11Day_EmptyTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //app.MapPost("/", () => "Hello World!");
            //app.MapPut("/", () => "Hello World!");
            //app.MapDelete("/", () => "Hello World!");

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello Hugh Jackman!!");
            //    await context.Response.WriteAsync("\nHow are you!!");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Bye Hugh Jackman!!");
            //});


            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Hello Hugh Jackman!!");
                await context.Response.WriteAsync("\nHow are you!!");
                next(context);
            });
            
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("\nWolvarine");
                next(context);
                await context.Response.WriteAsync("\nLogan");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\n Byee");
            });
            app.Run();
        }
    }
}

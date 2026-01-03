namespace _11Day_BasicMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Bind Services :Setting application Dependencies
            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            app.MapDefaultControllerRoute();
            

            app.Run();
        }
    }
}

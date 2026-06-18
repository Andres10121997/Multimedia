using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Web.App.Start
{
    public static class Startup
    {
        public static WebApplication InitApp(string[] args)
        {
            #region Objects
            WebApplicationBuilder builder;
            WebApplication app;
            #endregion

            builder = WebApplication.CreateBuilder(args: args);

            ConfigureServices(Builder: builder);

            app = builder.Build();

            Configure(App: app);

            return app;
        }



        #region Configure
        private static void ConfigureServices(WebApplicationBuilder Builder)
        {
            // Add services to the container.
            Builder.Services.AddRazorPages();
        }

        public static void Configure(WebApplication App)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

            // Configure the HTTP request pipeline.
            if (!App.Environment.IsDevelopment())
            {
                App.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                App.UseHsts();
            }

            App.UseHttpsRedirection();

            App.UseRouting();

            App.UseAuthorization();

            App.MapStaticAssets();
            App.MapRazorPages()
               .WithStaticAssets();
        }
        #endregion
    }
}
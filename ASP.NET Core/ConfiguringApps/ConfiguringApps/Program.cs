using ConfiguringApps.Infrastructures;

internal class Program
{
    private static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        builder.WebHost.UseKestrel().UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);
                config.AddEnvironmentVariables();
                if (args != null)
                {
                    config.AddCommandLine(args);
                }
            }).
            ConfigureLogging((hostingContext, logging) =>
            {
                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                logging.AddConsole();
                logging.AddDebug();
            })
        .UseIISIntegration()
        .UseDefaultServiceProvider((context, options) =>
        {
            options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
        });


        builder.Services.AddSingleton<UptimeService>();
        builder.Services.AddMvc(options => options.EnableEndpointRouting = false)
            .AddMvcOptions(options => { options.RespectBrowserAcceptHeader = true; });

        var app = builder.Build();


        if ((app.Configuration.GetSection("ShortCircuitMiddleware")?.GetValue<bool>("EnableBrowserShortCircuit")).Value)
        {
            app.UseMiddleware<BrowserTypeMiddleware>();
            app.UseMiddleware<ShortCircuitMIddleware>();
        }

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseMvc(routes =>
        {
            routes.MapRoute(
                name: "deafult",
                template: "{controller=Home}/{action=Index}/{id?}"
                );
        });

        app.Run();
    }
}
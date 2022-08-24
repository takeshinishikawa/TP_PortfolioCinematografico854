using Microsoft.Extensions.DependencyInjection;
using Portfolio.Domain;
using Portfolio.Domain.Enum;
using Portfolio.Services;
using System;


namespace Portfolio.Presentation;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    //[STAThread]
    static void Main()
    {

        ServiceCollection services = new();
        ConfigureServices(services);

        var serviceProvider = services.BuildServiceProvider();
        var bdUsers = serviceProvider.GetService<IUserRepository>();
        var portService = serviceProvider.GetService<IPortfolioService>();
        var movieList = serviceProvider.GetService<IMovieRepository>();

        InitDB.NewUsers(bdUsers);
        InitDB.AddMovies(movieList);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new @ref());
        //Application.Run(new FrmRegistration());
        Application.Run(new FrmLogin(bdUsers, portService, movieList));
        //Application.Run(new FrmAbout());

    }

    public static void ConfigureServices(IServiceCollection services)
    {
        services
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IPortfolioService, PortfolioService>()
            .AddScoped<IMovieRepository, MovieRepository>();
    }
}
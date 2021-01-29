using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Recipes.Data;
using Recipes.Data.Contracts;
using Recipes.Data.Repositories;
using Recipes.Services.Data;
using Recipes.Services.Data.Contracts;
using System;
using System.Windows.Forms;

namespace Recipes.Desktop
{
    static class Program
    {
        public static void ConfigureServices(IServiceCollection services)
        {

            // TODO: Extract in configuration
            services.AddDbContext<RecipeContext>(options => options.UseSqlServer("Server=.;Database=RecipeApp;User Id=sa;Password=123456!!XX;"));

            // Data repositories
            // typeof - no need to specify the generic and pass it from the interface to the implementation
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            // TODO: AddTransient, AddScoped - explanation
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRecipeService, RecipeService>();
            services.AddTransient<IFavouriteRecipeService, FavouriteRecipeService>();

            // when it sees Authentication form, resolves every dependency using the mappings above
            services.AddScoped<AuthenticationForm>();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // WinForms settings
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // dependency injection mappings
            // mapping - for every interface makes an instance of something that implements that interface
            var services = new ServiceCollection();
            ConfigureServices(services);

            // creates objects that have resolved dependencies 
            using (var serviceProvider = services.BuildServiceProvider())
            {
                // resolves dependencies and creates the form
                var authenticationForm = serviceProvider.GetRequiredService<AuthenticationForm>();
                // starts the application with the Authentication form
                Application.Run(authenticationForm);
            }
        }
    }
}

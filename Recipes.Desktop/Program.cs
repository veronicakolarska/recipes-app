using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Recipes.Data;
using Recipes.Data.Common.Repositories;
using Recipes.Data.Repositories;
using Recipes.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRecipeService, RecipeService>();
            services.AddTransient<IFavouriteRecipeService, FavouriteRecipeService>();
            services.AddTransient<IIngredientService, IngredientService>();

            services.AddScoped<Authentication>();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var authenticationForm = serviceProvider.GetRequiredService<Authentication>();
                Application.Run(authenticationForm);
            }
        }
    }
}

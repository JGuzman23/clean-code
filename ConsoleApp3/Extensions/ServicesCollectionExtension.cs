using ConsoleApp.BL;
using ConsoleApp.Contracts.BL;
using ConsoleApp.Contracts.Controllers;
using ConsoleApp.Contracts.Repository;
using ConsoleApp.Contracts.Services;
using ConsoleApp.Repository;
using ConsoleApp.Services;
using ConsoleApp3.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp3.Extensions
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IExamenesServicio, ExamenService>();

            services.AddTransient<IAsistenciaService, AsistenciaService>();

            services.AddTransient<IExposicionService, ExposicionService>();

            services.AddTransient<IMateriaService, MateriaService>();

            services.AddTransient<IMostrarCalificacionService, MostrarCalificacionesService>();

            services.AddTransient<ICuatrimestreService, CuatrimestreServicio>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IMateriaRepository, MateriasRepository>();
            services.AddTransient<IExamenRepository, ExamenRepository >();
            services.AddTransient<ICalificacionRepository, CalificacionRepository>();
            services.AddTransient<IAsistenciaRepository, AsistenciaRepository>();
            services.AddTransient<IExposicionRepository, ExposicionRepository>();


            return services;
        }

        public static IServiceCollection AddBL(this IServiceCollection services)
        {
            services.AddTransient<IHelperService, HelperService>();
            return services;
        }

        public static IServiceCollection AddControllers(this IServiceCollection services)
        {
            services.AddTransient<IMateriaController, MateriaController>();
            return services;
        }


    }
}

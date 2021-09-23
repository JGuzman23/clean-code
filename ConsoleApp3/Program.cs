using AutoMapper;
using ConsoleApp.Contracts.BL;
using ConsoleApp.Contracts.Controllers;
using ConsoleApp.Contracts.Services;
using ConsoleApp.Models;
using ConsoleApp.Models.Profiles;
using ConsoleApp3.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleApp3
{
    class Program
    {
       
        private readonly IMapper _mapper;
        private readonly IHelperService _helperService;
        private readonly IExamenesServicio _examenServicio;
        private readonly IAsistenciaService _asistenciaService;
        private readonly IExposicionService _exposicionService;
        private readonly IMateriaService _materiaService;
        private readonly IMostrarCalificacionService _MostrarCalificacionService;
        private readonly ICuatrimestreService _cuatrimestreService;

        private readonly IMateriaController _materiaController;



        public Program(IMapper mapper,
            IHelperService helperService,
            IExamenesServicio examenesServicio, 
            IAsistenciaService asistenciaServicio, 
            IExposicionService exposicionServide,
            IMateriaService materiaService,
            IMostrarCalificacionService mostrarCalificacionService,
            ICuatrimestreService cuatrimestreService,

            IMateriaController materiaController)
        {
            _examenServicio = examenesServicio;
            _asistenciaService = asistenciaServicio;
            _exposicionService = exposicionServide;
            _materiaService = materiaService;
            _MostrarCalificacionService = mostrarCalificacionService;
            _cuatrimestreService = cuatrimestreService;
            _mapper = mapper;
            _helperService = helperService;

            _materiaController = materiaController;
        }
       
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args)
                .Build();

            host.Services
            .GetRequiredService<Program>()
            .Run();          

        }

        public void Run()
        {
         
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("Cuantos cuatrimestres tiene la carrera?");
            int cantidadCuatrimestre = Convert.ToInt32(Console.ReadLine());
            

            if (!_helperService.ValidarSiNumeroEsMayorCero(cantidadCuatrimestre))
            {
                Console.WriteLine("No puede registrar materia cuando el cuatrimestre es menor o igual a 0");
                return; 
            }

            
            for (int i = 0; i < cantidadCuatrimestre; i++)
            {
                Console.WriteLine($"cuantas materias tiene el cuatrimestre :  ");
                int cantidadMateria = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < cantidadMateria; j++)
                {
                    Console.WriteLine("Ingrese la materia");
                    string materia = Console.ReadLine();

                    _materiaController.Create(materia, i);                    
                }
            }

            var materias = _materiaController.GetAll();


            Console.WriteLine("Desea ver todas las materias agregadas?");
            Console.WriteLine("Precione Y para si, delo contrario precione cualquier letra para continuar ");
            string resp = Console.ReadLine();

            if (resp.ToLower() == "y")
            {
                for (int i = 0; i < materias.Count; i++)
                {
                    Console.WriteLine(materias[i]);
                }
            }
            else
            {
                Console.WriteLine("Notas");
                
                
                for (int i = 0; i < materias.Count; i++)
                {
                    Console.WriteLine($"Introduce la cantidad de examen dados en:  {materias[i].Nombre} ");
                    int canExamen =Convert.ToInt32(Console.ReadLine());
                    var materiaDtos = new ConsoleApp.Models.DTOs.MateriaDto { Nombre = materias[i].Nombre } ;
                    var examenDtos = new ConsoleApp.Models.DTOs.ExamenDto { canExman = canExamen };
                     _examenServicio.Ingresar(_mapper.Map<Examen>(examenDtos), _mapper.Map<Materia>(materiaDtos));
                }
                var canExamanes = _examenServicio.GetInfo();
             
                foreach (var item in canExamanes)
                {
                    for (int i = 0; i < item.CanExmane; i++)
                    {
                        Console.WriteLine($"Introduce la nota del examen  de {item.Materia} ");
                        Console.WriteLine($"Examen {i + 1}");
                        int nota = Convert.ToInt32(Console.ReadLine());
                         _examenServicio.Introducir(nota,item.Materia);
                    }
                }

                for (int i = 0; i < materias.Count; i++)    
                {
                    Console.WriteLine($"Introduce la asistencia {materias[i].Nombre} ");

                    int asist = Convert.ToInt32(Console.ReadLine());
                    var asistenciaDto = new ConsoleApp.Models.DTOs.AsistenciaDto { Valor = asist };
                    _asistenciaService.Ingresar(_mapper.Map<Asistencia>(asistenciaDto));
                }             

                for (int i = 0; i < materias.Count; i++)
                {
                    Console.WriteLine($"Introduce expociciones {materias[i].Nombre} ");

                    int exposicion = Convert.ToInt32(Console.ReadLine());
                    var expoDto = new ConsoleApp.Models.DTOs.ExposicionDto { valor = exposicion };


                    _exposicionService.Ingresar(_mapper.Map<Exposicion>(expoDto)); ;

                }




                //_MostrarCalificacionService.Mostrar(_mapper.Map<List< materias );
            }
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
            {
                
                services.AddAutoMapper(typeof(EstudiantesProfile).Assembly);
                services.AddTransient<Program>();
                services.AddRepositories();
                services.AddServices();
                services.AddControllers();
                services.AddBL();

            });


    }
}

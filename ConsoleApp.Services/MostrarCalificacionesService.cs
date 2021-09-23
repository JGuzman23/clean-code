using ConsoleApp.Contracts.Services;
using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Services
{
    public class MostrarCalificacionesService: IMostrarCalificacionService
    {
        List<Calificacion> calificaciones;

        public List<Calificacion> Mostrar(List<Materia> materias )
        {                     

            for (int i = 0; i < materias.Count; i++)
            {
                Console.WriteLine(materias[i]);
                                
                var notas = calificaciones.Where(c => c.Materia == materias[i].Nombre);
                


                foreach (var item in notas)
                {
                    Console.WriteLine(item.Nota);

                }
            }
            return calificaciones;

        }
    }
}

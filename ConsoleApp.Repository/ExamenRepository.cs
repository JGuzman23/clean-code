using ConsoleApp.Contracts.Repository;
using ConsoleApp.Models;
using System.Collections.Generic;

namespace ConsoleApp.Repository
{
    public class ExamenRepository :Repository<Examen> ,IExamenRepository 
    {
        List<Calificacion> calificaciones = new List<Calificacion>();


        List<CantidadExamen> canExamenes;



        public void Ingresar(Examen exam, Materia mat)
        {
            if (canExamenes == null)
            {
                canExamenes = new List<CantidadExamen>();
            }
            canExamenes.Add(new CantidadExamen { CanExmane = exam.canExman, Materia = mat.Nombre });

        }

        public List<CantidadExamen> GetInfo()
        {
            

            return canExamenes;
        }


        public List<Calificacion> Introducir(int nota, string materia)
        {



            calificaciones.Add(new Calificacion { Nota = nota, Materia = materia });
            return calificaciones;

        }

    }
}

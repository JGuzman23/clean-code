using ConsoleApp.Models.DTOs;

namespace ConsoleApp.Models.Profiles
{
    public class EstudiantesProfile : AutoMapper.Profile
    {
        public EstudiantesProfile()
        {
            CreateMap<MateriaDto, Materia>();
            CreateMap<Materia, MateriaDto>();

            CreateMap<ExamenDto, Examen>();
            CreateMap<Examen, ExamenDto>();

            CreateMap<AsistenciaDto, Asistencia>();
            CreateMap<Asistencia, AsistenciaDto>();

            CreateMap<ExposicionDto, Exposicion>() ;
            CreateMap<Exposicion, ExposicionDto>();

                


        }
    }
}

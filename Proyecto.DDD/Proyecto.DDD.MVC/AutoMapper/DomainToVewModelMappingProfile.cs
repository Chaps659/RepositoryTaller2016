using AutoMapper;
using Proyecto.DDD.Dominio.Entidades;
using Proyecto.DDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.DDD.MVC.AutoMapper
{
    public class DomainToVewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<VistaAlumno, Alumno>();
            Mapper.CreateMap<VistaProfesor, Profesor>();
        }
    }
}
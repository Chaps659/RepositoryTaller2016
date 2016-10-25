using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto.DDD.Dominio.Entidades;
using Proyecto.DDD.Data.Contexto;
using Proyecto.DDD.Data.Repositorio;

namespace Proyecto.DDD.Test.Data
{

    [TestClass]
    public class AgregarDatos
    {
        [TestMethod]
        public void AgregarAlumnoRepositorio()
        {

           var RepositoryAlu = new RepositoryAlumno();

            var NuevoAlumno = new Alumno()
            {
                DNI = 35063838,
                Nombre = "Carlos",
                Apellido = "Tevez",
                Descripcion = "Vamos boca carajo",    
                Foto = "JamesLebron.jpg"                           
              
            };

            RepositoryAlu.Add(NuevoAlumno);
      
        }

        [TestMethod]
        public void AgregarProfesorRepositorio()
        {
            var RepositoryPro = new RepositoryProfesor();

            var NuevoProfesor = new Profesor()
            {
                DNI = 35063838,
                Nombre = "Carlos",
                Apellido = "Tevez",
                Materias = "Futbol",
                Correo = "Carlos@teves"

            };

            RepositoryPro.Add(NuevoProfesor);

        }

        [TestMethod]
        public void AgregarProfesorContext()
        {
            var _ProyectoContext = new ProyectoContext();

            var NuevoProfesor = new Profesor()
            {
                DNI = 35063838,
                Nombre = "Carlos",
                Apellido = "Tevez",
                Materias = "Futbol",
                Correo = "Carlos@teves"

            };
            _ProyectoContext.Personas.Add(NuevoProfesor);
            _ProyectoContext.SaveChanges();


        }
   }
}
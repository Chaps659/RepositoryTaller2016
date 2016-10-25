using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DDD.Dominio.Entidades
{
    public class Profesor : Persona
    {
        public string Materias { get; set; }

        public string Correo { get; set; }
        
    }
}

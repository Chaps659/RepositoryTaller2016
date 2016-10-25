using Proyecto.DDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DDD.Data.EntidadesConfig
{
    public class AlumnoConfig : EntityTypeConfiguration<Alumno>
    {
        public AlumnoConfig()
        {
            HasKey(c => c.PersonaID);

            Property(c => c.DNI)
                .IsRequired();

            Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Apellido)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Descripcion)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Foto)
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}

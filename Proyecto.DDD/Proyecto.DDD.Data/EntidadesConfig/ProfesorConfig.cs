using Proyecto.DDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DDD.Data.Contexto
{
    public class ProfesorConfig : EntityTypeConfiguration<Profesor>
    {
        public ProfesorConfig()
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

            Property(c => c.Materias)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Correo)
                .IsRequired()
                .HasMaxLength(300);
        }
    }
}

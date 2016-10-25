using Proyecto.DDD.Data.EntidadesConfig;
using Proyecto.DDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.DDD.Data.Contexto
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext()
            : base("ConexionDB")
        {

        }

        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlumnoConfig());
            modelBuilder.Configurations.Add(new ProfesorConfig());


            modelBuilder.Entity<Profesor>().ToTable("Profesor");
            modelBuilder.Entity<Alumno>().ToTable("Alumno");


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));


        }
    }
}

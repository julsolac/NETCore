using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Mapping.Almacen;
using Sistema.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos
{
    public class DbContextSistema : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)   // constructor de la clase
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  // metodo para mapear entidades con la base de datos
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ArticuloMap());

        }
    }
}

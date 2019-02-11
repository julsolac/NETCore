<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Almacen;

namespace Sistema.Datos.Mapping.Almacen
{
    public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    { 
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("articulo")
                .HasKey(a => a.idarticulo);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Almacen;

namespace Sistema.Datos.Mapping.Almacen
{
    public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    { 
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("articulo")
                .HasKey(a => a.idarticulo);
        }
    }
}
>>>>>>> 273299916a0db67885ada9a842706ff34d9a0425

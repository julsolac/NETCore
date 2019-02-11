<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Models.Almacen.Articulo
{
    public class CrearViewModel
    {
        [Required]
        public int idcategoria { get; set; }
        public string codigo { get; set; }
        [StringLength(50, MinimumLength = 3,
          ErrorMessage = "El nombre no debe tener más de 50 caracteres y menos de 3.")]
        public string nombre { get; set; }
        [Required]
        public decimal precio_venta { get; set; }
        [Required]
        public int stock { get; set; }
        public string descripcion { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Models.Almacen.Articulo
{
    public class CrearViewModel
    {
        [Required]
        public int idcategoria { get; set; }
        public string codigo { get; set; }
        [StringLength(50, MinimumLength = 3,
          ErrorMessage = "El nombre no debe tener más de 50 caracteres y menos de 3.")]
        public string nombre { get; set; }
        [Required]
        public decimal precio_venta { get; set; }
        [Required]
        public int stock { get; set; }
        public string descripcion { get; set; }
    }
}
>>>>>>> 273299916a0db67885ada9a842706ff34d9a0425

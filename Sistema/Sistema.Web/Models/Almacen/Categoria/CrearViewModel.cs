<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Web.Models.Almacen.Categoria
{
    public class CrearViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe de tener más de 50 caracters, ni menos de 3.")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Web.Models.Almacen.Categoria
{
    public class CrearViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe de tener más de 50 caracters, ni menos de 3.")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
    }
}
>>>>>>> 273299916a0db67885ada9a842706ff34d9a0425

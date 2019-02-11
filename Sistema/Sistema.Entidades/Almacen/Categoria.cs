<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Sistema.Entidades.Almacen
{
    public class Categoria
    {
        [Required]
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="El nombre no debe de tener más de 50 caracters, ni menos de 3.")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        public ICollection<Articulo> articulos { get; set; }

    }
}
=======
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Sistema.Entidades.Almacen
{
    public class Categoria
    {
        [Required]
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="El nombre no debe de tener más de 50 caracters, ni menos de 3.")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
        public bool condicion { get; set; }

        public ICollection<Articulo> articulos { get; set; }

    }
}
>>>>>>> 273299916a0db67885ada9a842706ff34d9a0425

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos;
using Sistema.Entidades.Almacen;
using Sistema.Web.Models.Almacen.Articulo;

namespace Sistema.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public ArticulosController(DbContextSistema context)
        {
            _context = context;
        }

        // GET: api/Articulos/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<ArticuloViewModel>> Listar()
        {
            var articulo = await _context.Articulos.Include(a => a.categoria).ToListAsync();

            return articulo.Select(a => new ArticuloViewModel
            {
                idarticulo = a.idarticulo,
                idcategoria = a.idcategoria,
                categoria = a.categoria.nombre,
                codigo = a.codigo,
                nombre = a.nombre,
                precio_venta = a.precio_venta,
                stock = a.stock,
                descripcion = a.descripcion,
                condicion = a.condicion
            });
        }

        // GET: api/Articulos/Mostrar/1
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Mostrar([FromRoute] int id)
        {

            var articulo = await _context.Articulos.Include(a=>a.categoria).SingleOrDefaultAsync(a=>a.idarticulo==id);

            if (articulo == null)
            {
                return NotFound();
            }

            return Ok(new ArticuloViewModel
            {
                idarticulo = articulo.idarticulo,
                idcategoria = articulo.idcategoria,
                categoria = articulo.categoria.nombre,
                codigo = articulo.codigo,
                nombre = articulo.nombre,
                precio_venta = articulo.precio_venta,
                stock = articulo.stock,
                descripcion = articulo.descripcion,
                condicion = articulo.condicion
            });
        }

        // PUT: api/Articulos/Actualizar
        [HttpPut("[action]")]
        public async Task<IActionResult> Actualizar([FromBody] ActualizarViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (model.idarticulo < 0)
            {
                return BadRequest();
            }

            var articulo = await _context.Articulos.FirstOrDefaultAsync(a => a.idarticulo == model.idarticulo);

            if (articulo == null)
            {
                return NotFound();
            }

            articulo.idcategoria = model.idcategoria;
            articulo.codigo = model.codigo;
            articulo.nombre = model.nombre;
            articulo.descripcion = model.descripcion;
            articulo.stock = model.stock;
            articulo.precio_venta = model.precio_venta;


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Guardar excepción
                return BadRequest();
            }

            return Ok();
        }

        // POST: api/Articulos/Crear
        [HttpPost("[action]")]
        public async Task<IActionResult> Crear([FromBody] CrearViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Articulo articulo = new Articulo
            {
               idcategoria = model.idcategoria,
               codigo = model.codigo,
               nombre = model.nombre,
               descripcion = model.descripcion,
               stock = model.stock,
               precio_venta = model.precio_venta,
               condicion = true
            };

            _context.Articulos.Add(articulo);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            return Ok();
        }

        // PUT: api/Articulos/Desactivar
        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> Desactivar([FromRoute] int id)
        {

            if (id <= 0)
            {
                return BadRequest();
            }

            var articulo = await _context.Articulos.FirstOrDefaultAsync(a => a.idarticulo == id);

            if (articulo == null)
            {
                return NotFound();
            }

            articulo.condicion = false;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Guardar excepción
                return BadRequest();
            }

            return Ok();
        }

        // PUT: api/Articulos/Activar
        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> Activar([FromRoute] int id)
        {

            if (id <= 0)
            {
                return BadRequest();
            }

            var articulo = await _context.Articulos.FirstOrDefaultAsync(a => a.idarticulo == id);

            if (articulo == null)
            {
                return NotFound();
            }

            articulo.condicion = true;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Guardar excepción
                return BadRequest();
            }

            return Ok();
        }

        private bool ArticuloExists(int id)
        {
            return _context.Articulos.Any(e => e.idarticulo == id);
        }
    }
}
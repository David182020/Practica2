using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using _2017HG601.Models;

namespace _2017HG601.Controllers
{
    [ApiController]     
    public class EquiposController : ControllerBase
    {
        private readonly Contexto _contexto;
        public EquiposController(Contexto miContexto) 
        {
            this._contexto = miContexto;
        }

        /*[HttpGet]
        [Route("api/ListaEquipos")]
        public IEnumerable<Equipos> getListadoEquipo()
        {
            IEnumerable<Equipos> listadoEquipo = _contexto.EQUIPO;
            return listadoEquipo;
        }*/
        
        [HttpGet]
        [Route("api/Listado")]
        public IActionResult Get()
        {
            IEnumerable<Equipos> Busqueda = from E in _contexto.EQUIPO select E;

            if (Busqueda.Count() > 0)
            {
                return Ok(Busqueda);
            }
            return NotFound();         
        } 
        [HttpGet]
        [Route("api/Busqueda")]
        public IActionResult getID(int ID)
        {
            Equipos Personal = (from E in _contexto.EQUIPO where E.id_equipos == ID select E).FirstOrDefault();
            if (Personal != null)
            {
                return Ok(Personal);
            }
            return NotFound();
        }
        [HttpPost]
        [Route("api/Insertar")]
        public IActionResult postGuardar([FromBody] Equipos Nuevo)
        {
            try
            {
                IEnumerable<Equipos> DISPONIBLE = from E in _contexto.EQUIPO where E.nombre == Nuevo.nombre select E;

                if (DISPONIBLE.Count() == 0)
                {
                    _contexto.EQUIPO.Add(Nuevo);
                    _contexto.SaveChanges();
                    return Ok(Nuevo);
                }
                return Ok(DISPONIBLE);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("api/Editar")]
        public IActionResult postModificar([FromBody] Equipos Modificar)
        {
            Equipos Disponible = (from E in _contexto.EQUIPO
                                    where E.id_equipos == Modificar.id_equipos
                                    select E).FirstOrDefault();
            if (Disponible is null)
            {
                return NotFound();
            }

            Disponible.nombre = Modificar.nombre;
            Disponible.descripcion = Modificar.descripcion;
            Disponible.modelo = Modificar.modelo;

            _contexto.Entry(Disponible).State = EntityState.Modified;
            _contexto.SaveChanges();
            
            return Ok(Disponible);
        }
    }
}
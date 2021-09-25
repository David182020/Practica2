using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2017HG601.Models;

namespace _2017HG601.Controllers
{
    [ApiController]     
    public class EstadoController : ControllerBase
    {
        private readonly Contexto _contexto;
        public EstadoController(Contexto miContexto) 
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/ListaEstado")]
        public IEnumerable<Estado> getListadoEstado()
        {
            IEnumerable<Estado> listadoEstado = _contexto.ESTADO;
            return listadoEstado;
        }   
    }
}
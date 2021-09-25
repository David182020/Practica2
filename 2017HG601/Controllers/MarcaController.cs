using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2017HG601.Models;

namespace _2017HG601.Controllers
{
    [ApiController]     
    public class MarcaController : ControllerBase
    {
        private readonly Contexto _contexto;
        public MarcaController(Contexto miContexto) 
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/ListaMarca")]
        public IEnumerable<Marca> getListadoMarca()
        {
            IEnumerable<Marca> listadoMarca = _contexto.MARCA;
            return listadoMarca;
        }   
    }
}
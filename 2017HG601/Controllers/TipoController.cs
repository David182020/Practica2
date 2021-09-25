using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2017HG601.Models;

namespace _2017HG601.Controllers
{
    [ApiController]     
    public class TipoController : ControllerBase
    {
        private readonly Contexto _contexto;
        public TipoController(Contexto miContexto) 
        {
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/ListaTipo")]
        public IEnumerable<Tipo> getListadoTipo()
        {
            IEnumerable<Tipo> listadoTipo = _contexto.TIPO;
            return listadoTipo;
        }  
    }
}
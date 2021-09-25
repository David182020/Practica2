using System;
using System.ComponentModel.DataAnnotations;
using _2017HG601.Models;

namespace _2017HG601.Models
{
    public class Estado
    {
        [Key]
        public int id_estados_equipo { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }    
    }
}
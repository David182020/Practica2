using System;
using System.ComponentModel.DataAnnotations;
using _2017HG601.Models;

namespace _2017HG601.Models
{
    public class Marca
    {
        [Key]
        public int id_marcas { get; set; }
        public string nombre_marca { get; set; }
        public string estado { get; set; }    
    }
}
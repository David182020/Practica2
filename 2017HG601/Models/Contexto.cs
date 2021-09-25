using Microsoft.EntityFrameworkCore;
using _2017HG601.Models;

namespace _2017HG601
{
    public class Contexto : DbContext
    {
        //Constructor - Conexión de Base De Datos
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        //Entidades - Modelos de Datos de equiposBD
        public DbSet<Equipos> EQUIPO { get; set; }
        public DbSet<Estado> ESTADO { get; set; }
        public DbSet<Marca> MARCA { get; set; }
        public DbSet<Tipo> TIPO { get; set; }
    }
}
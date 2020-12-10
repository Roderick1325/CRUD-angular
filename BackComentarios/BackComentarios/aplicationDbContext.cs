using System;
using BackComentarios.Models;
using Microsoft.EntityFrameworkCore;

namespace BackComentarios
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Comentario> Comentario { get; set; }
        public AplicationDbContext()
        {

        }
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (optionBuilder.IsConfigured)
            {
                optionBuilder.UseMySql("Server=localhost;Database=dbComent;Uid=rodrigo;Pwd=Roderick12;");
            }
            
        }

    }
}

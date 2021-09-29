using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades que vão virar tabelas no banco

        //Tabela de pessoas cadastrados
        public DbSet<Pessoa> Pessoas { get; set; }


    }
}
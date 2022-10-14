//Utilizaç]ao de um Namespace
using ApiVoeAirlines.Entities;
using Microsoft.EntityFrameworkCore;
using Voeairlines.EntityConfigurations;


//Conjunto de classes
namespace Voeairlines.Contexts;

//o que è uma Classe?

//É um conjunto de objetos.
public class VoeDb : DbContext
{
    private readonly IConfiguration _configuration;

    public VoeDb(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("VoeAirlines"));
    }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
        modelBuilder.ApplyConfiguration(new AeronaveConfiguration());

 }
    //class --> é um conjunto de objetos.

    //Classe - é um conjunto de objetos.

    /*   
    -------------------------------------------------------------
    Aeronave 
    -------------------------------------------------------------
      Fabricante : string
      Categoria : int
      Modelo: String
      codigo: 

        */
    //Herança
    // O que é uma classe?
    //O que é uma Herança?

}
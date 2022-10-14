namespace ApiVoeAirlines.Entities;

public class Aeronave
{
    public Aeronave(int id, string nome, string modelo, string fabricante, string codigo, int tipoLicenca)
    {
        Id = id;
        Nome = nome;
        Modelo = modelo;
        Fabricante = fabricante;
        Codigo = codigo;
        TipoLicenca = tipoLicenca;
    }

    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Modelo { get; set; }

    public string? Fabricante { get; set; }

    public string? Codigo { get; set; }

    public int TipoLicenca { get; set; }



}


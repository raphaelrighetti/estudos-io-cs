namespace ByteBankIO.Modelos;

public class Cliente
{
    public Cliente(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public string? CPF { get; set; }
    public string? Profissao { get; set; }
}

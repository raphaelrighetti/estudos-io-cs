namespace ByteBankIO.Modelos;

public class Cliente
{
    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
    }

    public string Nome { get; set; }
    public string CPF { get; set; }
    public string? Profissao { get; set; }
}

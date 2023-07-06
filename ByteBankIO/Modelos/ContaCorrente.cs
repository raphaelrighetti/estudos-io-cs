using System.Globalization;

namespace ByteBankIO.Modelos;

public class ContaCorrente
{
    public int Numero { get; }
    public int Agencia { get; }
    public double Saldo { get; private set; }
    public Cliente Titular { get; set; }

    public ContaCorrente(int numero, int agencia, string nome, string? cpf, string? profissao)
    {
        Numero = numero;
        Agencia = agencia;
        Titular = new(nome)
        { 
            CPF = cpf,
            Profissao = profissao
        };
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de deposito deve ser maior que zero.", nameof(valor));
        }

        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de saque deve ser maior que zero.", nameof(valor));
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }

        Saldo += valor;
    }

    public override string ToString()
    {
        string texto =
            $"Número: {Numero}, " +
            $"Agência: {Agencia}, " +
            $"Saldo: {Saldo.ToString(new CultureInfo("en-US"))}, " +
            $"Titular: {Titular.Nome}";

        return texto;
    }
}

using ByteBankIO.Modelos;
using System.Globalization;
using System.Text;

//var caminhoArquivo = "contas.csv";
var caminhoNovoArquivo = "contas-exportadas.csv";

//LerArquivoDiretamente(caminhoArquivo);
//LerArquivoComStreamReader(caminhoArquivo);
//EscreverArquivoDiretamente(caminhoNovoArquivo);
EscreverArquivoComStreamWriter(caminhoNovoArquivo);

Console.ReadKey();

static void LerArquivoDiretamente(string caminho)
{
    var numeroBytesLidos = -1;

    using var fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);

    var buffer = new byte[1024];

    while (numeroBytesLidos != 0)
    {
        numeroBytesLidos = fs.Read(buffer, 0, buffer.Length);
        EscreverConteudo(buffer, numeroBytesLidos);
    }
}

static void EscreverConteudo(byte[] buffer, int bytesLidos)
{
    var utf8 = new UTF8Encoding();
    var conteudo = utf8.GetString(buffer, 0, bytesLidos);

    Console.Write(conteudo);
}

static void LerArquivoComStreamReader(string caminho)
{
    using var fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);
    using var sr = new StreamReader(fs);

    while (!sr.EndOfStream)
    {
        var linha = sr.ReadLine();
        var conta = ConverterLinhaParaContaCorrente(linha!);

        Console.WriteLine(conta);
    }
}

static ContaCorrente ConverterLinhaParaContaCorrente(string linha)
{
    var campos = linha.Split(',');

    int numero = int.Parse(campos[0]);
    int agencia = int.Parse(campos[1]);
    double saldo = double.Parse(campos[2], new CultureInfo("en-US"));
    string nome = campos[3];

    var conta = new ContaCorrente(numero, agencia, nome, null, null);
    conta.Depositar(saldo);

    return conta;
}

static void EscreverArquivoDiretamente(string caminho)
{
    string conteudo = "123,1234,1000.25,Jamelão Santos";
    var encoding = Encoding.UTF8;
    var bytes = encoding.GetBytes(conteudo);

    using var fs = new FileStream(caminho, FileMode.Create);

    fs.Write(bytes, 0, bytes.Length);
}

static void EscreverArquivoComStreamWriter(string caminho)
{
    string conteudo = "321,4321,2500.25,Silvio Santos";

    using var fs = new FileStream(caminho, FileMode.Create);
    using var sw = new StreamWriter(fs);

    sw.WriteLine(conteudo);
}

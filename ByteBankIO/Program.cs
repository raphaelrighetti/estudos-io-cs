using System.Text;

var caminhoArquivo = "contas.txt";

//LendoArquivoDiretamente(caminhoArquivo);
LendoArquivoComStreamReader(caminhoArquivo);

Console.ReadKey();

static void LendoArquivoDiretamente(string caminho)
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

static void LendoArquivoComStreamReader(string caminho)
{
    using var fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);

    var leitor = new StreamReader(fs);

    while (!leitor.EndOfStream)
    {
        var linha = leitor.ReadLine();
        Console.WriteLine(linha);
    }
}

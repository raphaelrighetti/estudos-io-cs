using ByteBankIO.Modelos;
using System.Text;

var caminhoArquivo = "contas.txt";
var numeroBytesLidos = -1;

using (var fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read))
{
    var buffer = new byte[1024];

    while (numeroBytesLidos != 0)
    {
        numeroBytesLidos = fs.Read(buffer, 0, buffer.Length);
        EscreverConteudo(buffer);

        Array.Clear(buffer, 0, buffer.Length);
    }
}

Console.ReadKey();

void EscreverConteudo(byte[] buffer)
{
    var utf8 = new UTF8Encoding();
    var conteudo = utf8.GetString(buffer);

    Console.Write(conteudo);
}

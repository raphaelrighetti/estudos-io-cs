# Estudos de IO no C#

Neste repositório irei registrar os meus estudos do curso "C#: trabalhando com arquivos" da Alura, curso este onde vou aprender a como trabalhar com fluxos de dados, leitura e escrita de arquivos e coisas desse tipo em C#.

Todas as anotações que faço enquanto vejo as aulas podem ser encontradas no arquivo "anotacoes.txt" na raiz do repositório.

## C#: trabalhando com arquivos

### Aula 1

#### Lendo um arquivo de texto

Nesta aula aprendi a ler o conteúdo de um arquivo de texto com C# utilizando o método "Read()" da classe "FileStream", que nos permite armazenar o fluxo de dados que estamos trabalhando em um buffer e ir utilizando esse buffer até todo o arquivo ser lido, mesmo que o tamanho do buffer seja menor que a quantidade de bytes que o arquivo em questão possui.

Além disso, aprendi a utilizar a classe "UTF8Encoding" para transformar o conteúdo do buffer em uma string que respeita a tabela unicode com o método "GetString()", assim fazendo com que a string aceite caracteres especiais, como caracteres com acento e etc.

### Aula 2

#### Usando o StreamReader

Nesta aula aprendi a facilitar a leitura de um Stream utilizando a classe "StreamReader", que nos fornece métodos para manipularmos fluxos de dados de maneira mais fácil do que eu havia aprendido na aula anterior, mas que faz o que eu estava fazendo por baixo dos panos.

Além disso, vi mais detalhes sobre o "using ()" que faz com que referências "IDisposable" sejam descartadas ao final do bloco e aprendi a como utilizar classes parciais (partial class).

Também vi que podemos passar mais argumentos para o método "GetString()" do UTF8Encoding, de forma que especificamos de onde até onde o conteúdo do buffer deve ser lido por ele, assim evitando duplicação de informações sem ter que ficar esvaziando o buffer a cada "Read()".

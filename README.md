# Estudos de IO no C#

Neste repositório irei registrar os meus estudos do curso "C#: trabalhando com arquivos" da Alura, curso este onde vou aprender a como trabalhar com fluxos de dados, leitura e escrita de arquivos e coisas desse tipo em C#.

Todas as anotações que faço enquanto vejo as aulas podem ser encontradas no arquivo "anotacoes.txt" na raiz do repositório.

## C#: trabalhando com arquivos

### Aula 1

#### Lendo um arquivo de texto

Nesta aula aprendi a ler o conteúdo de um arquivo de texto com C# utilizando o método "Read()" da classe "FileStream", que nos permite armazenar o fluxo de dados que estamos trabalhando em um buffer e ir utilizando esse buffer até todo o arquivo ser lido, mesmo que o tamanho do buffer seja menor que a quantidade de bytes que o arquivo em questão possui.

Além disso, aprendi a utilizar a classe "UTF8Encoding" para transformar o conteúdo do buffer em uma string que respeita a tabela unicode com o método "GetString()", assim fazendo com que a string aceite caracteres especiais, como caracteres com acento e etc.

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

### Aula 3

#### Criando um arquivo

Nesta aula aprendi a fazer escrita em um arquivo utilizando o FileStream e também o StreamWriter, que nos auxilia com métodos mais simples de serem utilizados e que não precisamos fazer a conversão de string para bytes manualmente para utilizar.

Além disso, aprendi sobre o "CultureInfo", que é uma classe que define um padrão de formatação baseado em uma cultura de um país/localidade. Ela é muito útil para definirmos a formatação que ocorre em um método "Parse()" ou em uma conversão de datas para strings, nos permitindo modificar o padrão de formatação para o adequado dependendo da cultura que escolhemos.

Também pude ver mais detalhes sobre o FileMode e como ele muda o comportamento do nosso FileStream.

### Aula 4

#### Flush() e arquivos binários

Nesta aula aprendi um pouco mais sobre o funcionamento da classe StreamWriter e o seu método "Flush()", que nos permite limpar o buffer utilizado para a escrita no fluxo dados e fazer de fato a escrita no momento em que quisermos, sem que ela seja feita apenas no fechamento do fluxo de dados com o qual estamos trabalhando.

Além disso, aprendi sobre as classes "BinaryReader" e "BinaryWriter", que nos permitem trabalhar com leitura e escrita de arquivo binários.

### Aula 5

#### Stream do Console e classe File

Nesta aula aprendi a abrir um Stream usando o input padrão do Console do C#, por meio do método "OpenStandardInput()" dele. Todos os métodos do Console que recebem um input do usuário e retornam o valor dele utilizam algo parecido por baixo dos panos e facilitam bastante a nossa vida, mas é interessante saber que podemos fazer isso utilizando um Stream diretamente também.

Além disso, aprendi sobre a classe "File", que é uma classe estática que possui vários métodos que nos auxiliam a realizar ações de leitura e escrita de forma mais simples em arquivos, apesar de não ser recomendada quando temos um arquivo muito grande ou precisamos fazer algo mais complexo.

### Conclusão

Neste curso pude aprender muito sobre como funciona o sistema de input e output do C# trabalhando com arquivos ".txt", ".csv", arquivos binários e muito mais coisas.

Achei muito interessante e mais intuitivo que no Java mexer com os fluxos de dados no C#, entendi melhor como funcionam os buffer quando estamos trabalhando com streams e pude praticar bastante tudo isso que eu aprendi.

Foi um curso muito bom e que fico feliz de ter feito, estou animado para continuar com os meus estudos em C#.

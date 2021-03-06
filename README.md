# C#
# Matrizes e instruções de repetição 

### Matrizes

As matrizes na linguagem C#, nos permite armazenar sequências de valores em uma única estrutura de dados. É um tipo especial de variável que pode conter vários valores do mesmo tipo de dados. A sintaxe da declaração é um pouco diferente porque é necessário especificar o tipo de dados e o tamanho da matriz. 

* Para declarar uma matriz de cadeias de caracteres para conter três elementos, pode ser digitada a seguinte linha de código:

```C#
string[] PaletaDeCores = new string[3];
```

* Para atribuir valores a elementos de uma matriz:

```C#
string[] PaletaDeCores = new string[3];

PaletaDeCores[0] = "Azul";
PaletaDeCores[1] = "Vermelho";
PaletaDeCores[2] = "Verde";
```
* Se for necessário descobrir o tamanho de uma matriz, pode ser inserida a seguinte linha de código:

```C#
Console.WriteLine($"Na paleta possui {PaletaDeCores.Length} cores.");
```
* As matrizes podem ter mais de uma dimensão. Por exemplo, a declaração abaixo cria uma matriz bidimensional de quatro linhas e duas colunas.

```C#
int[,] array = new int[4, 2];
```

### Instruções de repetição

As estruturas de repetição são usadas para controlar a execução de códigos repetidamente até que uma condição seja verdadeira. 

* A instrução *for* executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como *true*.
Em qualquer ponto dentro do bloco de instrução *for*, você pode sair do loop usando a instrução *break* ou seguir para a próxima iteração no loop usando a instrução *continue*. Você também pode sair de um for loop pelas instruções *goto*, *Return* ou *throw* .
Exemplo de instrução com seções definidas: 

```C#
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

* A instrução *while* executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como *true*. Como essa expressão é avaliada antes de cada execução do loop, um loop *while* é executado zero ou mais vezes. A qualquer momento dentro do bloco de instruções *while*, interrompa o loop usando a instrução *break*. Exemplo de uso da instrução *while*:

```C#
int n = 0;
while (n < 5)
{
    Console.WriteLine(n);
    n++;
}
```

* A instrução *do* executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como *true*. Como essa expressão é avaliada após cada execução do loop, um loop *do-while* é executado uma ou mais vezes. Isso é diferente do loop *while*, que é executado zero ou mais vezes.

```C#
int n = 0;
do
{
    Console.WriteLine(n);
    n++;
} while (n < 5);
```

* A instrução *foreach* realiza um loop em cada elemento da matriz, executando o bloco de código abaixo da declaração e substituindo o valor em uma variável temporária pelo valor da matriz representada pelo loop atual. Abaixo um exemplo simples de uso da instrução *foreach*:

```C#
string[] names = { "Junior", "Sales", "Gabriel" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
```

// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
#region 2) Tipos de dados
    Console.WriteLine("2) Tipos de dados");
    Console.WriteLine("Tipos de dados numéricos inteiros:");
    Console.WriteLine($"---Sbyte com faixa de valores entre {sbyte.MinValue} a {sbyte.MaxValue}");
    Console.WriteLine("\t Exemplo de uso: Representação de idades, pois costumam ser valores pequenos");

    Console.WriteLine($"---Byte com faixa de valores entre {byte.MinValue} a {byte.MaxValue}");
    Console.WriteLine("\t Exemplo de uso: Tons de azul em RGB");

    Console.WriteLine($"---Short com faixa de valores entre {short.MinValue} a {short.MaxValue}");
    Console.WriteLine("\t Exemplo de uso: Temperatura em graus Celsius");

    Console.WriteLine($"---Ushort com faixa de valores entre {ushort.MinValue} a {ushort.MaxValue}");
    Console.WriteLine("\t Exemplo de uso: Contagem de itens em um estoque de médio à pequeno porte");

    Console.WriteLine($"---Int com faixa de valores entre {int.MinValue} a {int.MaxValue}");
    Console.WriteLine("\t Exemplo de uso: Indice de um array ou lista");

    Console.WriteLine($"---Uint com faixa de valores entre {uint.MinValue} a {uint.MaxValue}");
    Console.WriteLine("\t Exemplo de uso: Armazenamento de tamanhos de arquivo ou posições em uma matriz.");

    Console.WriteLine($"---Long com faixa de valores entre {long.MinValue} a {long.MaxValue}");
    Console.WriteLine("\t Exemplo de uso: Para situações que requerem um intervalo de valores muito amplo.");

    Console.WriteLine($"---Ulong com faixa de valores entre {ulong.MinValue} a {ulong.MaxValue}");
    Console.WriteLine("\t Exemplo de uso: Armazenamento de identificadores únicos (hashes) que não podem ser negativos.");

    Console.WriteLine("------EXTRA------");
    Console.WriteLine("BigInteger é uma classe que faz parte do namespace System.Numerics no .NET, usado quando existe situações onde a precisão ou a magnitude dos números é crucial, como em cálculos matemáticos avançados, criptografia ou qualquer cenário que envolva manipulação de números extremamente grandes");

#endregion

#region 3) Conversão de Tipos de Dados:
    double valorDouble = 10.6;
    Console.WriteLine("\n3) Conversão de Tipos de Dados:");
    //int valorInteiro = double.Parse(valorDouble); não é possível converter double para int usando o método Parse. Ao usar esse método, em casos de não compatibilidade, o programa não é compilado.
    Console.WriteLine("\nCaso 1:Casting Explícito:(a parte fracionária será truncada) ");
    int valorInteiro = (int)valorDouble;
    Console.WriteLine($"Resultado da conversão de {valorDouble} para int: {valorInteiro}");
    Console.WriteLine("\nCaso 2: Método Parse, neste caso o TryParse: ");
    try
    {
        valorInteiro = int.Parse(valorDouble.ToString());
    }
    catch (FormatException)
    {
        //quando não for possivel converte irá cair no catch, exibindo a mensagem abaixo
        Console.WriteLine($"A conversão de {valorDouble} para int não é possível(mas assim o programa continua o seu fluxo)");
    }

    Console.WriteLine("\n\nProblema: Oque fazer quando a parte fracionaria é importante para o valor final mas não precisa ser exibida? ");
    Console.WriteLine("\nSolução: Usar o método Math.Round(a parte fracionaria será considerada) pois ele arredonda o valor para o inteiro mais próximo. ");
    valorInteiro = (int)Math.Round(valorDouble);
    Console.WriteLine($"Resultado da conversão de {valorDouble} para int: {valorInteiro}");
    

#endregion 

#region 4) Operadores Aritméticos:
    int x = 10;
    int y = 3;
    Console.WriteLine("\n4) Operadores Aritméticos:");
    Console.WriteLine($"Operador de Soma: {x} + {y} = {x + y}");
    Console.WriteLine($"Operador de Subtração: {x} - {y} = {x - y}");
    Console.WriteLine($"Operador de Multiplicação: {x} * {y} = {x * y}");
    Console.WriteLine($"Operador de Divisão: {x} / {y} = {x / y}");
#endregion

#region 5) Operadores de Comparação:
    int a = 5;
    int b = 8;
    Console.WriteLine("\n5) Operadores de Comparação:");
    Console.WriteLine($"Operador de Maior que: {a} > {b} = {a > b}");

#endregion

#region 6) Operadores de Igualdade:
    string str1 = "Hello";  
    string str2 = "World";
    Console.WriteLine("\n6) Operadores de Igualdade:");
    Console.WriteLine($"Operador de Igualdade: ({str1} == {str2}) -> {str1 == str2}");

#endregion

#region 7) Operadores Lógicos:
    bool condicao1 = true;
    bool condicao2 = false;
    Console.WriteLine("\n7) Operadores Lógicos:");
    Console.WriteLine($"Operador AND: ({condicao1} && {condicao2}) -> {condicao1 && condicao2}");
#endregion

#region 8) Desafio de Mistura de Operadores:
    int num1 = 7;
    int num2 = 3;
    int num3 = 10;
    Console.WriteLine("\n8) Desafio de Mistura de Operadores:");
    Console.WriteLine($"( ({num1} > {num2}) && ({num1+num2} == {num3}) ) -> {(num1>num2)&&(num1+num2==num3)}");

#endregion
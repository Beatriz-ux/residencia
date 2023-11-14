#region Exercicio 1
/*
    Escreva um programa em C# que imprime todos os números que são
    divisíveis por 3 ou por 4 entre 0 e 30;
*/
Console.WriteLine("Exercicio 1: Números divisíveis por 3 ou 4 entre 0 e 30");
for(int i=0;i<=30;i++){
    if(i%3 == 0 || i%4 == 0)  
        Console.Write(i + ",");
        
}
#endregion
#region Exercicio 2
/*
    Faça um programa em C# que imprima os primeiros números da série de
    Fibonacci até passar de 100. A série de Fibonacci é a seguinte: 0, 1, 1, 2, 3,
    5, 8, 13, 21 etc... Para calculá-la, o primeiro elemento vale 0, o segundo vale
    1, daí por diante, o n-ésimo elemento vale o (n-1)-ésimo elemento somado
    ao (n-2)-ésimo elemento (ex: 8 = 5 + 3)
*/
int fib1=0,fib2=1,fib3;
fib3 = fib1 + fib2;
Console.WriteLine("\nExercicio 2: Sequencia de Fibonacci");
Console.Write(fib1 + "," + fib2 + ","+ fib3 + ",");

do{
    fib1 = fib2;
    fib2 = fib3;
    fib3 = fib1 + fib2;
    Console.Write(fib3 + ",");
}while(fib3<=100);
#endregion

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

// Tradução: “para cada…”, ou seja, realize algo para cada item de uma coleção/lista
/*
    pecorre do inicio ao fim de uma lista
    string[] colecao= { "Item1", "Item2", "Item3", "Item4" };
    foreach (string qualquerNome in colecao)
    {
        Console.WriteLine(qualquerNome);
    }
*/
string[] mercado = {"Banana", "Maçã", "Arroz", "Uva", "Feijao"};
Console.WriteLine("Lista de compras:");
foreach (string item in mercado)
{
    Console.WriteLine(item);
}

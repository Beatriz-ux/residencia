#region 
    string? name = Console.ReadLine();
    name = name?.Trim();
    Console.WriteLine($"Hello {name}!");

    string?[] names = name.Split(' ');

    names[0] = names[0].ToUpper();
    foreach (string? item in names)
    {
        Console.WriteLine(item);
    }

#endregion

#region Array
object[] array = new object[3]; //cria um tipo generico , mas ao adicionar o primeiro elemento ele se torna do tipo do elemento adicionado

#endregion

#region List
//Linq : acesso e procura de dados, se assemelha ao sql
//Count : conta a quantidade de elementos
//Add : adiciona um elemento
//AddRange : adiciona uma lista de elementos
//contains : verifica se existe um elemento
//Sort : ordena os elementos
//Reverse : inverte a ordem dos elementos
//Remove : remove um elemento
//RemoveAt : remove um elemento pelo indice
//ForEach : percorre a lista
//Find : procura um elemento
//Clear : limpa a lista , mas ainda fica o espaço de memoria
//TrimExcess : limpa a lista e o espaço de memoria

List<int> numbers = new List<int>();//só é possivel usar a lista após alocar memoria "new.."
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);

Console.WriteLine($"{numbers.Count} elementos");


//matriz ou array de 2 dimensoes
List<List<string>> matriz = new List<List<string>>();
matriz.Add(new List<string>(){
    "a","b","c"
});

matriz.Add(new List<string>(){
    "d","e","f"
});

foreach (List<string> item in matriz)
{
    foreach (string? item2 in item)
    {
        Console.WriteLine(item2);
    }
}
#endregion

#region DateTime
//date caso não passe nada, ela é inicializada com 01/01/0001
//comparação de datas, devemos usar o today pq a horas é padronizada com 00:00:00
DateTime now = DateTime.Now;
DateTime today = DateTime.Today;

Console.WriteLine(now);
Console.WriteLine(today);

DateTime christmas = new DateTime(2023,12,25,0,0,0);
Console.WriteLine("Natal" + christmas.DayOfWeek);

DateTime start = new DateTime(2021,1,1);
DateTime end = new DateTime(2021,12,31);
TimeSpan duration = end - start;
#endregion


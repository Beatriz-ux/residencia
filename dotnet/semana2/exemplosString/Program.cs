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


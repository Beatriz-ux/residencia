using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
// See https://aka.ms/new-console-template for more information
#region tuples examples
// var tuple = (10,20);
// Console.WriteLine($"tuple.Item1: {tuple.Item1} tuple.Item2: {tuple.Item2}");
// var tuple2 = (x: 10, y: 20);
// Console.WriteLine($"tuple2.x: {tuple2.x} tuple2.y: {tuple2.y}");

// var tuple3 = (id: 1, nome: "João", idade: 20, born: new DateTime(1987, 9, 24));
// Console.WriteLine($"tuple3.id: {tuple3.id} tuple3.nome: {tuple3.nome} tuple3.idade: {tuple3.idade} tuple3.born: {tuple3.born}");

// var tuple4 = (id: 1, nome: "João", born: new DateTime(1987, 9, 24));

// List<(int id, string nome,DateTime born)> lista = new ();
// lista.Add((2, "Bia", new DateTime(1987, 9, 24)));
// lista.Add(tuple4);
// lista.ForEach(x => Console.WriteLine($"x.id: {x.id} x.nome: {x.nome} x.born: {x.born.ToShortDateString()}"));

#endregion

#region exercicio
// string nome = Console.ReadLine() ?? "";
// DateTime dataNascimento = DateTime.Parse(Console.ReadLine() ?? "");

// (string, int) calculaIdade (DateTime dataNascimento, string nome){
//     int idade = DateTime.Now.Year - dataNascimento.Year;
//     Console.WriteLine(DateTime.Now.Year - dataNascimento.Year);

//     if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
//         idade--;
//     return (nome, idade);

// }
// var tupla = calculaIdade(dataNascimento, nome);

// //var tupla = calculaIdade(new DateTime(2001, 2, 19), "João");


// Console.WriteLine(tupla.Item2);

#endregion

#region exercicio2 lambdas
// string [] people = {"João", "Maria", "José", "Bia", "Ana", "Pedro", "Paulo", "Carlos", "Joaquim", "Joaquina"};
// char letter = 'J';
// Console.WriteLine($"Pessoas que começam com a letra {letter} {string.Join(",",people.Where(x => x.StartsWith(letter)))}");

// Console.WriteLine($"Pessoas que começam com a letra {letter} {string.Join(",",people.Where(x => x.StartsWith(letter)).Select(x => x.ToUpper()))}");
#endregion

#region exercicios linq
    // List<int> lista = new (){9,2,3,4,5};
    // var squared = lista.Select(x => x * x);
    // Console.WriteLine($"Lista: {string.Join(",", lista)}");
    // Console.WriteLine($"Squard: {string.Join(",", squared)}");

    // var sumeList= lista.Select((x,index)=> x + squared.ElementAt(index));//como tem o mesmo tamanho, pode usar o index
    // Console.WriteLine($"Sumer: {string.Join(",", sumeList)}");

    // var listMultOfThree = lista.Where(x => x % 3 == 0).ToList();
    // listMultOfThree.AddRange(squared.Where(x => x % 3 == 0).ToList());
    // listMultOfThree.AddRange(sumeList.Where(x => x % 3 == 0).ToList());
    // Console.WriteLine($"Mult of three: {string.Join(",", listMultOfThree)}");

    // Console.WriteLine($"Mult of three: Order {string.Join(",", listMultOfThree.Order())}");



#endregion

#region debugging e execptions
// //breakpoint vc marca o codigo com uma bolinha vermelha e a partir dali seguir linha a linha ou pular para o prx
// string nome = Console.ReadLine() ?? "";
// try{
// DateTime dataNascimento = DateTime.Parse(Console.ReadLine() ?? "");
// var tupla = calculaIdade(dataNascimento, nome);
// }catch(FormatException ex){
//     Console.WriteLine($"Formato de data invalido: {ex.Message}");
// }catch(Exception ex){
//     Console.WriteLine($"Erro: {ex.Message}");
// }

// (string, int) calculaIdade (DateTime dataNascimento, string nome){
//     int idade = DateTime.Now.Year - dataNascimento.Year;
//     Console.WriteLine(DateTime.Now.Year - dataNascimento.Year);

//     if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
//         idade--;
//     return (nome, idade);

// }


#endregion

#region execptions
// try{
//     Console.WriteLine(divide(10,0));

// }
// catch(DivideByZeroException ex){
//     Console.WriteLine($"Erro: {ex.Message}");
// }
// catch(Exception ex){
//     Console.WriteLine("An erros has ocurred");
//     Console.WriteLine($"Erro: {ex.Message}");
// }
// finally{
//     Console.WriteLine("Finally block executed");
// }


// int divide(int a, int b){
//     if (b == 0)
//         throw new DivideByZeroException("Não é possível dividir por zero");
//     return a / b;
// }
#endregion

#region class


#endregion
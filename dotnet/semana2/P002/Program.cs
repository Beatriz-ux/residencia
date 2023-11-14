int opcao ;
List<string> tarefas = new List<string>();
do{
    Console.WriteLine("1- Criar tarefa"+
    "2- Listar tarefas"+
    "3- Marcar tarefa concluida"+
    "4- Listar tarefas concluidas"+
    "5- Listar tarefas pendentes"+
    "6- Excluir tarefa"+
    "7- Encontrar tarefa"+
    "8- Dashboard"+
    "0- Sair");
    opcao = int.Parse(Console.ReadLine());

    switch(opcao){
        case 1:
            Console.WriteLine("Digite a tarefa");
            string tarefa = Console.ReadLine();
            Console.WriteLine("Digite a data de conclusão:");
            DateTime data = DateTime.Parse(Console.ReadLine());
            tarefa += $" - {data}";

            tarefas.Add(tarefa);

            Console.WriteLine("Tarefa adicionada com sucesso:"+tarefa);
            break;

        case 2:
            Console.WriteLine("Listando tarefas");
            int i = 0;
            foreach (string item in tarefas)
            {   
                Console.WriteLine($"{i} - {item}");
            }
            break;

        case 3:
            Console.WriteLine("Digite o indice da tarefa");
            int indice = int.Parse(Console.ReadLine());
            tarefas.RemoveAt(indice);
            Console.WriteLine("Tarefa removida com sucesso");
            break;
        
        case 4:
            Console.WriteLine("Listando tarefas concluidas");
            foreach (string item in tarefas)
            {   
                if(item.Contains("concluida")){
                    Console.WriteLine(item);
                }
            }
            break;




    }
}
while(opcao  !=0);
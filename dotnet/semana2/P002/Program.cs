int opcao ;
int id=1;
int concluidas = 0;
List<string[]> tarefas = new List<string[]>();
do{
    Console.WriteLine("\n1- Criar tarefa\n"+
    "2- Listar tarefas\n"+
    "3- Marcar tarefa concluida\n"+
    "4- Listar tarefas concluidas\n"+
    "5- Listar tarefas pendentes\n"+
    "6- Excluir tarefa\n"+
    "7- Pesquisar tarefa\n"+
    "8- Dashboard\n"+
    "0- Sair");
    opcao = int.Parse(Console.ReadLine());

    switch(opcao){
        case 1:
            Console.WriteLine("Digite o titulo da tarefa:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Digite a descrição da tarefa:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite a data de conclusão da tarefa: dd/MM/yyyy");
            string data = Console.ReadLine();
            string identificador = id.ToString("D4");
            titulo = titulo.ToLower();
            descricao = descricao.ToLower();

            string[] tarefa = {identificador,titulo,descricao, data, "false"};
            tarefas.Add(tarefa);
            id++;
            break;
        case 2:
            Console.WriteLine($"{"id",-10} {"Titulo",-30} {"Descrição",-45} {"Data",-14}");
            foreach(string[] t in tarefas){
                if(t[4] == "false"){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{t[0],-10} {t[1],-30} {t[2],-45} {t[3],-14}");
                    Console.ResetColor();
                }
                else
                    Console.WriteLine($"{t[0],-10} {t[1],-30} {t[2],-45} {t[3],-14}");
            }
            break;
        case 3:
            bool achouId = false;
            Console.WriteLine("Digite o id da tarefa:");
            string idTarefa = Console.ReadLine();
            foreach(string[] t in tarefas){
                if(t[0] == idTarefa ){
                    if(t[4] == "true"){
                        Console.WriteLine("Tarefa já concluida");
                    }else{
                        Console.WriteLine("Tarefa concluida!!!");
                        t[4] = "true";
                        concluidas++;
                        
                    }
                    achouId = true;
                    break;
                    
                }
            }
            if(!achouId)
                Console.WriteLine("Tarefa não encontrada");
            break;
        case 4:
            Console.WriteLine($"{"id",-10} {"Titulo",-30} {"Descrição",-45} {"Data",-14}");
            foreach(string[] t in tarefas){
                if(t[4] == "true"){
                    Console.WriteLine($"{t[0],-10} {t[1],-30} {t[2],-45} {t[3],-14}");
                }
            }
            break;
        case 5:
            Console.WriteLine($"{"id",-10} {"Titulo",-30} {"Descrição",-45} {"Data",-14}");
            foreach(string[] t in tarefas){
                if(t[4] == "false"){
                    Console.WriteLine($"{t[0],-10} {t[1],-30} {t[2],-45} {t[3],-14}");
                }
            }
            break;
        case 6:
            bool deletou = false;
            Console.WriteLine("Digite o id da tarefa:");
            string idTarefaExcluir = Console.ReadLine();
            foreach(string[] t in tarefas){
                if(t[0] == idTarefaExcluir){
                    tarefas.Remove(t);
                    if(t[4] == "true"){
                        concluidas--;
                        deletou = true;
                        break;
                    }
                        
                }
            }
            if(!deletou)
                Console.WriteLine("Tarefa não encontrada");
            break;
        
        case 7:
            bool achou = false;
            Console.WriteLine("Digite oque quer buscar:");
            string buscarTarefa = Console.ReadLine();
            buscarTarefa = buscarTarefa.ToLower();
            Console.WriteLine("Resultado da busca:");
            foreach(string[] t in tarefas){
                if(t[0] == buscarTarefa || t[1].Contains(buscarTarefa) || t[2].Contains(buscarTarefa) || t[3].Contains(buscarTarefa)){
                    Console.WriteLine($"{t[0],-10} {t[1],-30} {t[2],-45} {t[3],-14}");
                    achou = true;
                  
                }
            }
            if(!achou){
                Console.WriteLine("Tarefa não encontrada");
            }
            break;

        case 8:
            Console.WriteLine($"Dashboard");
            Console.WriteLine("----------------------------------");
            int pendentes = tarefas.Count - concluidas;
            Console.Write("Seu progresso: ");
            for(int i=0;i<pendentes;i++){
                Console.Write("□ ");
            }
            for(int i=0;i<concluidas;i++){
                Console.Write("■ ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{"pendentes",-10} {"concluidas",-10}");
            Console.WriteLine($"{pendentes,-10} {concluidas,-10}");
            Console.WriteLine();
            Console.WriteLine();
            if(tarefas.Count > 0){
                int posicao = encontraAntiga(tarefas);
                Console.WriteLine($"Tarefa mais antiga: ({tarefas[posicao][3]})");
                Console.WriteLine(tarefas[posicao][0]+" "+tarefas[posicao][1]);


                posicao = encontraRecente(tarefas);
                Console.WriteLine($"Tarefa mais recente: ({tarefas[posicao][3]})");
                Console.WriteLine(tarefas[posicao][0]+" "+tarefas[posicao][1]);
            }
            
            break;


        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
while(opcao  !=0);

static int encontraAntiga(List<string[]> tarefas){
    int antiga = 0;
    DateTime dataAntiga = DateTime.ParseExact(tarefas[0][3], "dd/MM/yyyy", null);
    for(int i=0;i<tarefas.Count;i++){
        DateTime data = DateTime.ParseExact(tarefas[i][3], "dd/MM/yyyy", null);
        if(data < dataAntiga){
            dataAntiga = data;
            antiga = i;
        }
    }
    return antiga;
}
static int encontraRecente(List<string[]> tarefas){
    int recente = 0;
    DateTime dataRecente = DateTime.ParseExact(tarefas[0][3], "dd/MM/yyyy", null);
    for(int i=0;i<tarefas.Count;i++){
        DateTime data = DateTime.ParseExact(tarefas[i][3], "dd/MM/yyyy", null);
        if(data > dataRecente){
            dataRecente = data;
            recente = i;
        }
    }
    return recente;
}


// See https://aka.ms/new-console-template for more information
using semana3.P003;
using System.Globalization;
List<Produto> produtos = new List<Produto>();
int resposta = 0;
do
{
    Console.WriteLine("1 - Menu sobre produtos");
    Console.WriteLine("2 - Relatório de produtos");
    Console.WriteLine("0 - Sair");
    try
    {
        resposta = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
        continue;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        continue;
    }
    switch (resposta)
    {
        case 1:
            menuProduto(produtos);
            break;
        case 2:
            menuRelatorio(produtos);
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

} while (resposta != 0);


static void menuProduto(List<Produto> produtos)
{
    int resposta = 0;
    do
    {
        Console.WriteLine();
        Console.WriteLine("---------------PRODUTO---------------");
        Console.WriteLine("1 - Cadastrar ");
        Console.WriteLine("2 - Listar ");
        Console.WriteLine("3 - Consultar");
        Console.WriteLine("4 - Registrar entrada");
        Console.WriteLine("5 - Registrar saída");
        Console.WriteLine("0 - Voltar");
        try
        {
            resposta = int.Parse(Console.ReadLine()!);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
            continue;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            continue;
        }
        switch (resposta)
        {
            case 1:
                produtos = App.cadastrarProduto(produtos);
                break;
            case 2:
                App.listarProdutos(produtos);
                break;
            case 3:
                Console.WriteLine("Informe o id do produto");
                try
                {
                    int id = int.Parse(Console.ReadLine()!);
                    Produto p = App.consultarProduto(produtos, id);
                    if (p != null)
                    {
                        Console.WriteLine($"{"Id",-10} {"Nome",-30} {"Preço",-14} {"QtdEstoque",-14}");
                        Console.WriteLine($"{p.getId(),-10} {p.getNome(),-30} {p.getPreco(),-14} {p.getQtdEstoque(),-14}");
                    }
                    else
                    {
                        throw new Exception("Produto não encontrado");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;

            case 4:
                Console.WriteLine("Informe o id do produto");
                try
                {
                    int id = int.Parse(Console.ReadLine()!);
                    Produto p = App.consultarProduto(produtos, id);
                    if (p != null)
                    {
                        Console.WriteLine("Informe a quantidade a ser adicionada");
                        int qtd = int.Parse(Console.ReadLine()!);
                        if (qtd < 0)
                        {
                            throw new Exception("Quantidade não pode ser negativa");
                        }
                        else if (qtd == 0)
                        {
                            throw new Exception("Quantidade não pode ser zero");
                        };
                        App.entradaProdutos(produtos, id, qtd);

                    }
                    else
                    {
                        throw new Exception("Produto não encontrado");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            case 5:
                Console.WriteLine("Informe o id do produto");
                try
                {
                    int id = int.Parse(Console.ReadLine()!);
                    Produto p = App.consultarProduto(produtos, id);
                    if (p != null)
                    {
                        Console.WriteLine("Informe a quantidade a ser removida");
                        int qtd = int.Parse(Console.ReadLine()!);
                        if (qtd < 0)
                        {
                            throw new Exception("Quantidade não pode ser negativa");
                        }
                        else if (qtd == 0)
                        {
                            throw new Exception("Quantidade não pode ser zero");
                        };
                        App.saidaProdutos(produtos, id, qtd);

                    }
                    else
                    {
                        throw new Exception("Produto não encontrado");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            case 0:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

    } while (resposta != 0);

}

static void menuRelatorio(List<Produto> produtos)
{
    int resposta = 0;
    do
    {
        Console.WriteLine();
        Console.WriteLine("---------------RELATÓRIO---------------");
        Console.WriteLine("1 - Produtos com quantidade em estoque abaixo de X");
        Console.WriteLine("2 - Produtos com valor entre um mínimo e um máximo");
        Console.WriteLine("3 - Relatório Financeiro ");
        Console.WriteLine("4 - Produtos com estoque zerado");
        Console.WriteLine("0 - Voltar");
        try
        {
            resposta = int.Parse(Console.ReadLine()!);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
            continue;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            continue;
        }
        switch (resposta)
        {
            case 1:
                Console.WriteLine("Informe a quantidade limite de estoque:");
                try
                {
                    int qtd = int.Parse(Console.ReadLine()!);
                    if (qtd < 0)
                    {
                        throw new Exception("Quantidade não pode ser negativa");
                    }
                    else if (qtd == 0)
                    {
                        throw new Exception("Quantidade não pode ser zero");
                    }
                    App.relatorioEstoqueBaixo(produtos, qtd);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }


                break;
            case 2:
                Console.WriteLine("Informe o valor mínimo:");
                try
                {
                    float min = float.Parse(Console.ReadLine()!);
                    if (min < 0)
                    {
                        throw new Exception("Valor não pode ser negativo");
                    }
                    Console.WriteLine("Informe o valor máximo:");
                    float max = float.Parse(Console.ReadLine()!);
                    if (max < 0)
                    {
                        throw new Exception("Valor não pode ser negativo");
                    }
                    if (min > max)
                    {
                        throw new Exception("Valor mínimo não pode ser maior que o valor máximo");
                    }

                    App.relatorioIntervaloPreco(produtos, min, max);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                break;
            case 3:
                App.relatorioFinanceiro(produtos);
                break;
            case 4:
                App.relatorioEstoqueZerado(produtos);
                break;
            case 0:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

    } while (resposta != 0);
}
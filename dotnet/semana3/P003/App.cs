using System.Runtime.InteropServices;

namespace semana3.P003;

public class App
{
    public static List<Produto> cadastrarProduto(List<Produto> produtos)
    {
        string nome;
        float preco;
        int qtd;
        string resposta = "s";
        do
        {
            Console.WriteLine("Informe o nome do produto");
            nome = Console.ReadLine()!;
            nome = nome.ToUpper();//converte para maiusculo
            try
            {
                Console.WriteLine("Informe o preço do produto");
                preco = float.Parse(Console.ReadLine()!);
                if (preco < 0)
                {
                    throw new Exception("Preço não pode ser negativo");
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
            Console.WriteLine("Informe a quantidade do produto");
            try
            {
                qtd = int.Parse(Console.ReadLine()!);
                if (qtd < 0)
                {
                    throw new Exception("Quantidade não pode ser negativa");
                }
                else if (qtd == 0)
                {
                    throw new Exception("Quantidade não pode ser zero");
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

            produtos.Add(new Produto(nome, preco, qtd));

            Console.WriteLine("Deseja cadastrar outro produto? (s/n)");
            resposta = Console.ReadLine()!;
        } while (resposta.ToLower() == "s");
        return produtos;
    }

    public static void listarProdutos(List<Produto> produtos)
    {
        Console.WriteLine($"{"Id",-10} {"Nome",-30} {"Preço",-14} {"QtdEstoque",-14}");
        produtos.ForEach(p => Console.WriteLine($"{p.getId(),-10} {p.getNome(),-30} {p.getPreco(),-14} {p.getQtdEstoque(),-14}"));

    }

    public static Produto consultarProduto(List<Produto> produtos, int id)
    {

        Produto p = produtos.Find(x => x.getId() == id);
        try
        {

            if (p != null)
            {
                return p;
            }
            else
            {
                throw new Exception("Produto não encontrado");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return null;
    }
    public static void entradaProdutos(List<Produto> produtos, int id, int qtd)
    {
        Produto p = consultarProduto(produtos, id);
        try
        {
            if (p != null)
            {
                p.setQtdEstoque(p.getQtdEstoque() + qtd);
                Console.WriteLine($"Quantidade atualizada: {p.getQtdEstoque()}");
            }
            else
            {
                throw new Exception("Produto não encontrado");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void saidaProdutos(List<Produto> produtos, int id, int qtd)
    {
        Produto p = consultarProduto(produtos, id);
        try
        {
            if (p != null)
            {
                if (p.getQtdEstoque() >= qtd)
                {
                    p.setQtdEstoque(p.getQtdEstoque() - qtd);
                    Console.WriteLine($"Quantidade atualizada: {p.getQtdEstoque()}");

                }
                else
                {
                    throw new Exception("Quantidade em estoque insuficiente");
                }
            }
            else
            {
                throw new Exception("Produto não encontrado");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void relatorioEstoqueBaixo(List<Produto> produtos, int qtd)
    {
        List<Produto> produtosBaixos = produtos.Where(p => p.getQtdEstoque() <= qtd).OrderBy(p => p.getQtdEstoque()).ToList();
        listarProdutos(produtosBaixos);

    }

    public static void relatorioEstoqueZerado(List<Produto> produtos)
    {
        List<Produto> produtosZerados = produtos.Where(p => p.getQtdEstoque() == 0).ToList();
        listarProdutos(produtosZerados);
    }

    public static void relatorioIntervaloPreco(List<Produto> produtos, float minimo, float maximo)
    {
        List<Produto> produtosIntervalo = produtos.Where(p => p.getPreco() >= minimo && p.getPreco() <= maximo).OrderBy(p => p.getPreco()).ThenBy(p => p.getNome()).ToList();
        listarProdutos(produtosIntervalo);
    }

    public static void relatorioFinanceiro(List<Produto> produtos)
    {
        float total = produtos.Sum(p => p.getPreco() * p.getQtdEstoque());
        Console.WriteLine($"Valor total em estoque: R$ {total.ToString("F2")}");
        var valorTotalPorProduto = produtos.Select(p => new
        {
            Nome = p.getNome(),
            ValorTotal = p.getPreco() * p.getQtdEstoque()
        });
        Console.WriteLine("\nValor total de cada produto de acordo com o estoque:");
        foreach (var produto in valorTotalPorProduto)
        {
            Console.WriteLine($"{produto.Nome}: R$ {produto.ValorTotal.ToString("F2")}");
        }


    }




}

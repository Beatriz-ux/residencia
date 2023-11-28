namespace semana3.P003
{
    public class Produto
    {
        public Produto(string nome, float preco,int qtd)
        {
            Id = IdProdutos++;
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtd;
        }
        private static int IdProdutos { get; set; } = 10000;
        private int Id { get; set; } 
        private string Nome { get; set; }
        private float Preco { get; set; }
        private int QtdEstoque { get; set; }

        public int getId()
        {
            return Id;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getNome()
        {
            return Nome;
        }
        public void setPreco(float preco)
        {
            Preco = preco;
        }
        public float getPreco()
        {
            return Preco;
        }
        public void setQtdEstoque(int qtd)
        {
            QtdEstoque = qtd;
        }
        public int getQtdEstoque()
        {
            return QtdEstoque;
        }





    }
}


namespace exercico___3._1
{
    public class produto
    {
        /*classe representa algo no mundo reail*/
        public string NOME { get; set; }

        public string CODIGO { get; set; }

        public string PRECO { get; set; }

        public string ESTOQUE { get; set; }

        public string VALORDOESTOQUE { get; set; }

        /* é necessario um metodod construtor para acessar as propriedades e manipular elas*/
        public produto(string nome, string codigo, string preco, string estoque, string valordoestoque)
        {
            NOME = nome;
            CODIGO = codigo;
            PRECO = preco;
            ESTOQUE = estoque;
            VALORDOESTOQUE = valordoestoque;

        }
        public void Produto1()
        {
            Console.WriteLine($"valor de estoque é {VALORDOESTOQUE}");
        }

        public void Produto2()
        {
            Console.WriteLine($"valor de estoque é {VALORDOESTOQUE}");
        }

        public void Produto3()
        {
            Console.WriteLine($"valor de estoque é {VALORDOESTOQUE}");
        }
    }
}

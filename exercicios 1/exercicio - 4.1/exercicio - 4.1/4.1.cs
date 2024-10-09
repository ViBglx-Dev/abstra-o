namespace exercicio___4._1
{
    public class carro  
    {
        /*classe representa algo no mundo reail*/
        public string MARCA { get; set; }

        public string MODELO { get; set; }

        public string VELOCIDADE { get; set; }

        public string ACELERACAO { get; set; }

        public string DESACELERACAO { get; set; }

        /* é necessario um metodod construtor para acessar as propriedades e manipular elas*/
        public carro(string marca, string modelo, string velocidade, string aceleracao, string desaceleracao)
        {
            MARCA = marca;
            MODELO = modelo;
            VELOCIDADE = velocidade;
            ACELERACAO = aceleracao;
            DESACELERACAO = desaceleracao;

        }
        public void aceleração1()
        {
            Console.WriteLine($"valor de estoque é {ACELERACAO}");
        }

        public void aceleração2()
        {
            Console.WriteLine($"valor de estoque é {ACELERACAO}");
        }

        public void aceleração3()
        {
            Console.WriteLine($"valor de estoque é {ACELERACAO}");
        }

    public void desaceleração1()
    {
        Console.WriteLine($"a desaceleração é de {DESACELERACAO}");
    }
        public void desaceleração2()
        {
            Console.WriteLine($"a desaceleração é de {DESACELERACAO}");
        }

        public void desaceleração3()
        {
            Console.WriteLine($"a desaceleração é de {DESACELERACAO}");
        }
    }
}

using ExemplosBrotas;

namespace _02___abstracao
{
    public class pet
    {
        /*classe representa algo no mundo reail*/
        public string Nome { get; set; }

        public string Raca { get; set; }

        public int Idade { get; set; }

        /* é necessario um metodod construtor para acessar as propriedades e manipular elas*/
        public pet(string nome, string raca, int idade)
        {
            Nome = nome;
            Raca = raca;
            Idade = idade;
        }

        /*metodo para alimentar*/
        public void Alimentar()
        {
            Console.WriteLine($"o pet {Nome} esta alimentado");
        }
    }
}

/* Classe de ALUNO com nascimento utilizando o tipo DATETIME */
namespace ExemplosBrotas
{
    public class Aluno
    {
        public DateTime Nascimento { get; set; }

        public Aluno(DateTime nascimento)
        {
            Nascimento = nascimento;
        }
    }
}

//Na Program com DATETIME//
Aluno aluno1 = new Aluno(new DateTime(2001, 8, 15));
Console.WriteLine("O aluno nasceu em " + aluno1.nascimento);
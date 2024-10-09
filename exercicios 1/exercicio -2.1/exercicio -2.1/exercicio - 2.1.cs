namespace exercicio__2._1;

 public class aluno
{
    /*classe representa algo no mundo reail*/
    public string RM { get; set; }

    public string Nome { get; set; }

    public string Nascimento { get; set; }

    public string Email { get; set; }

    /* é necessario um metodod construtor para acessar as propriedades e manipular elas*/
    public aluno(string rm, string nome, string nascimento, string email)
    {
        RM = rm;
        Nome = nome;
        Nascimento = nascimento;
        Email = email;

    }
}

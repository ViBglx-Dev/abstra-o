namespace exercicio___1._1
{
    public class livro
    {
        /*classe representa algo no mundo reail*/
        public string Titulo { get; set; }

        public string Autora { get; set; }

        public string Editora { get; set; }

        public string Anodelançamento { get; set; }

        /* é necessario um metodod construtor para acessar as propriedades e manipular elas*/
        public livro(string titulo, string autora, string editora, string anodelançamento)
        {
            Titulo = titulo;
            Autora = autora;
            Editora = editora;
            Anodelançamento = anodelançamento;

        }
    }
}


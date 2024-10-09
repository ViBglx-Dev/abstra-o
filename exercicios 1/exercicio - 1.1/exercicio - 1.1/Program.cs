using exercicio___1._1;

livro livro1 = new livro("acotar", "Sara j.mass","record","2015");

Console.WriteLine("o nome do livro é " + livro1.Titulo);
Console.WriteLine("a autora dele é a " + livro1.Autora);
Console.WriteLine("a editora que o lançou foi " + livro1.Editora);
Console.WriteLine("foi lançado no ano " + livro1.Anodelançamento);

livro livro2 = new livro("assim que acaba", "Collen hoover","Galera","2018");

Console.WriteLine("o nome do livro é " + livro2.Titulo);
Console.WriteLine("a autora dele é a " + livro2.Autora);
Console.WriteLine("a editora que o lançou foi " + livro2.Editora);
Console.WriteLine("foi lançado no ano " + livro2.Anodelançamento);

livro livro3 = new livro("verity", "collen hoover", "Galera","2018");

Console.WriteLine("o nome do livro é " + livro3.Titulo);
Console.WriteLine("a autora dele é a " + livro3.Autora);
Console.WriteLine("a editora que o lançou foi " + livro3.Editora);
Console.WriteLine("livro foi lançado no ano " + livro3.Anodelançamento);

Console.ReadKey();

using exercico___3._1;

produto produto1 = new produto("SABAO", "45678", "2,99", "5", "14,95");

Console.WriteLine("o nome do produto é " + produto1.NOME);
Console.WriteLine("o codigo do produto é " + produto1.CODIGO);
Console.WriteLine("o preço do produto é" + produto1.PRECO);
Console.WriteLine("o estoque é de " + produto1.ESTOQUE);
produto1.Produto1();

produto produto2 = new produto("COLA BASTAO", "9865", "3,99", "7", "27,93");

Console.WriteLine("o nome do produto é " + produto2.NOME);
Console.WriteLine("o codigo do produto é " + produto2.CODIGO);
Console.WriteLine("o preço do produto é" + produto2.PRECO);
Console.WriteLine(" o estoque é de " + produto2.ESTOQUE);
produto2.Produto2();

produto produto3 = new produto("OLEO CAPILAR", "462829", "34,99", "10", "349,90");

Console.WriteLine("o nome do produto é " + produto3.NOME);
Console.WriteLine("o codigo do produto é " + produto3.CODIGO);
Console.WriteLine("o preço do produto é" + produto3.PRECO);
Console.WriteLine(" o estoque é de " + produto3.ESTOQUE);
produto3.Produto3();

Console.ReadKey();
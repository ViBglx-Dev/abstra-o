/*instanciar a classe e nome*/

using _02___abstracao;

pet pet1 = new pet("rex", "Corgi", 12);


Console.WriteLine("o nome do seu cachorro é " + pet1.Nome);
Console.WriteLine("a raça do seu cachorro é " + pet1.Raca);
Console.WriteLine("e a idade do seu cachorro é " + pet1.Idade);
pet1.Alimentar();

Console.ReadKey();

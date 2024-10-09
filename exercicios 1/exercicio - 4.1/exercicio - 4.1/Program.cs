using exercicio___4._1;

carro carro1 = new carro("jeep", "commander blackhawk hurricane ", "100km/h", "50km/h", "20km/h");

Console.WriteLine("a marca do carro é " + carro1.MARCA);
Console.WriteLine("seu modelo é o " + carro1.MODELO);
Console.WriteLine("a velocidade é de" + carro1.VELOCIDADE);
carro1.aceleração1();
carro1.desaceleração1();

carro carro2 = new carro("mercedes", "G63 2024", "110km/h", "60km/h", "10km/h");

Console.WriteLine("a marca do carro é " + carro2.MARCA);
Console.WriteLine("seu modelo é o " + carro2.MODELO);
Console.WriteLine("a velocidade é de" + carro2.VELOCIDADE);
carro1.aceleração2();
carro1.desaceleração2();

carro carro3 = new carro("ferrari", "SF90 Stradale", "150km/h", "70km/h", "10km/h");

Console.WriteLine("a marca do carro é " + carro3.MARCA);
Console.WriteLine("seu modelo é o " + carro3.MODELO);
Console.WriteLine("a velocidade é de" + carro3.VELOCIDADE);
carro3.aceleração3();
carro3.desaceleração3();

Console.ReadKey();
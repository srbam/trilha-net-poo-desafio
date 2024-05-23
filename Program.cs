using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i = new Iphone("81998989898", "1111111132", "12312312", 8);
Nokia n = new Nokia("81998989877", "1111111144", 4);


Console.WriteLine(n.Numero);
Console.WriteLine(n.Memoria);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Play store");

Console.WriteLine(i.Numero);
Console.WriteLine(i.Memoria);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Apple store");




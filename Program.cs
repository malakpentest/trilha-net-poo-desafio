using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("210685462", "123456798", "Modelo A", 11);
nokia.InstalarAplicativo("Dio.me");
nokia.Ligar();


Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("123", "22222222", "Modelo b", 22);
iphone.InstalarAplicativo("WS");
iphone.ReceberLigacao();

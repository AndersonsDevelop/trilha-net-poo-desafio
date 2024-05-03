using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "(99)99999-9999", modelo: "Nokia G21", imei: "9999999999999999/00", memoria: 128);
Console.WriteLine($"Nokia: {nokia.Numero}");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
nokia.Ligar();

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "(98)98989-8989", modelo: "Iphone 15 Pro Max", imei: "888888888888888/00", memoria: 256);
Console.WriteLine($"Iphone: ");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();

using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("---------------Smartphone Nokia--------------------");
Smartphone nokia = new Nokia(numero: "(99)9999-9999", modelo: "Nokia 3250", imei: "000000-00-000000-0", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n---------------Smartphone Iphone--------------------");
Smartphone iphone = new Iphone(numero: "(98)99999-8888", modelo: "Iphone 16", imei: "111111-11-111111-1", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
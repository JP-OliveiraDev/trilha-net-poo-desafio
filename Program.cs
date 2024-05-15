using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "14894489", modelo: "Nokia 1", imei: "8454247512", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "5484516", modelo: "Iphone 11", imei: "4587451845", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Github");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "0123-4567", modelo: "Modelo 1", imei: "00000000", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Iphone(numero: "7890-1230", modelo: "Modelo 2", imei: "00000000", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");
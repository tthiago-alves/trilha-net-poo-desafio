using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone Nokia:");
Smartphone nokia = new Nokia(numero: "11947631483", modelo: "Nokia", imei: "123456", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smarthphone Iphone:");
Smartphone iphone = new Iphone(numero: "11947631488", modelo: "Iphone", imei: "1234567", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
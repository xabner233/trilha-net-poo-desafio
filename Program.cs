using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12 99716-3215", modelo: "Modelo 1.0", iMEI: 244466666, memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("Cartola");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "12 99632-5487", modelo: "12 ProMAX", iMEI: 335588795, memoria: 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Rei do Pitaco");
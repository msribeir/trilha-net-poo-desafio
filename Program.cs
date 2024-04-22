using DesafioPOO.Models;

Iphone iphone = new Iphone("123456", "XPS", "987654321", 128);
Console.WriteLine($"Smartphone Iphone - Modelo: {iphone.ObterModelo()} - Memoria: {iphone.ObterMemoria()} - IMEI: {iphone.ObterIMEI()}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("CandyCrush");

Console.WriteLine("");

Nokia nokia = new Nokia("654321", "AZ100", "123456789", 64);
Console.WriteLine($"Smartphone Nokia - Modelo: {nokia.ObterModelo()} - Memoria: {nokia.ObterMemoria()} - IMEI: {nokia.ObterIMEI()}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
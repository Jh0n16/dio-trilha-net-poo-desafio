using DesafioPOO.Models;

Nokia nokia = new Nokia("9999-9999", "Nokia 1", "123456789", 128);

Iphone iphone = new Iphone("8888-8888", "Iphone X", "987654321", 64);

nokia.InstalarAplicativo("YouTube");
nokia.Ligar();

Console.WriteLine("----------------------");

iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
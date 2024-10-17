using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia( "12345",  "Modelo1","11111111", 60);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone( "12345",  "Modelo1","11111111", 60);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");


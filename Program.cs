using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123", modelo:"Antigo",imei:"123",memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"321", modelo:"Novo",imei:"321",memoria:8);
iphone.Ligar();
iphone.InstalarAplicativo("LinkedIn");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123", "Nokia Modelo", "123456789", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("456", "iPhone Modelo", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
 iphone.InstalarAplicativo("Instagram");



using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nTeste Iphone:");
Smartphone iphone = new Iphone("12345678", "Iphone", "1010101", 120);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\nTeste Nokia:");
Smartphone Nokia = new Nokia("87654321", "Nokia", "22222", 52);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("VSCOCam");
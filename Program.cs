using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");

Smartphone meuNokia = new Iphone(numero: "8289998999", modelo: "SE", imei: "654654654", memoria: 128);
meuNokia.Ligar();
meuNokia.ReceberLigacao();
meuNokia.InstalarAplicativo("whatsap");

Console.WriteLine("\n");

Smartphone meuIphone = new Iphone(numero: "8254646548", modelo: "S90", imei: "65498745", memoria: 64);
meuIphone.Ligar();
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Telegram");
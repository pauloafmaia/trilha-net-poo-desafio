using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "1.1111-1111", modelo: "1", imei: "11111111", memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "2.2222-2222", modelo: "2", imei: "22222222", memoria: 256);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");
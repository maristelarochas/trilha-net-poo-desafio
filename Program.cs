using DesafioPOO.Models;
using Microsoft.VisualBasic;

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Tipo 1", imei: "123456789", memoria: 64);
nokia.InstalarAplicativo("Instagram");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("iPhone: ");
Smartphone iphone = new Iphone(numero: "98765432", modelo: "Tipo 2", imei: "23568989", memoria: 128);
iphone.InstalarAplicativo("Facebook");
iphone.Ligar();
iphone.ReceberLigacao();

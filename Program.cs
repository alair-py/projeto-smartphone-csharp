using Smartphone.Models;

Nokia nok = new Nokia(numero: "(31)9898-0000", modelo: "Lumia 520", imei: "1234567890", memoria: 4);
Iphone iph = new Iphone(numero: "(31)97575-1111", modelo: "Iphone X", imei: "0987654321", memoria: 16);

Console.WriteLine($"NOKIA NÚMERO: {nok.Numero}");
nok.Ligar(1189895555);
Console.WriteLine($"IPHONE NÚMERO: {iph.Numero}");
iph.ReceberLigacao();
nok.InstalarApp("Whatsapp");
iph.InstalarApp("Instagram");
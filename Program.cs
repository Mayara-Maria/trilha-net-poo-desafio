using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Iphone ip1 = new Iphone("123456789", "Xs", "5588mk", 15);
ip1.Ligar();
ip1.ReceberLigacao();
ip1.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Nokia nok1 = new Nokia("987654321", "MJ", "535f52s", 10);
nok1.Ligar();
nok1.InstalarAplicativo("Whatssapp");
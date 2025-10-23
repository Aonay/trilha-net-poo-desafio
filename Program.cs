using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone

System.Console.WriteLine("---------------------------------------------");
System.Console.WriteLine("Smartphone NOKIA:");
Nokia n1 = new Nokia("2345324", "MODELO1", "LKSDJF234234", 64);
n1.Ligar();
n1.ReceberLigacao();
System.Console.WriteLine("Instalando aplicativo Uber ...");
n1.InstalarAplicativo("Uber");

System.Console.WriteLine("---------------------------------------------");

System.Console.WriteLine("Smartphone IPHONE:");
Iphone i1 = new Iphone("789789", "MODELO2", "<MXCNV230948>", 32);
i1.Ligar();
i1.ReceberLigacao();
System.Console.WriteLine("Instalando aplicativo 99Taxi ...");
i1.InstalarAplicativo("99Taxi");
System.Console.WriteLine("---------------------------------------------");
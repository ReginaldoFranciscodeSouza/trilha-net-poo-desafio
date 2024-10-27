using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia g10 = new Nokia("102","Mokia 10","12012",16);
g10.InstalarAplicativo("tinderx");
g10.ReceberLigacao();

Console.WriteLine("Smartphone Iphone");
Iphone a10 = new Iphone("800","java11","542145",8);
a10.InstalarAplicativo("uol");
a10.Ligar();
// TODO: Realizar os testes com as classes Nokia e Iphone
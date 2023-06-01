// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Hello, World!");

var sehirler = new List<string>()
{
    "Ankara",
    "İstanbul",
    "Van",
    "Samsun",
    "Ordu"
};
/*
foreach (string s in sehirler)
{
    Console.WriteLine(s);
}*/

//Lambda expression =>
sehirler.ForEach (s => Console.WriteLine (s));

Console.WriteLine(new string('-',50));

var iller = sehirler;
iller.ForEach (i => Console.WriteLine (i));


sehirler.Add("Sinop");
sehirler.ForEach(s => Console.WriteLine (s));
Console.WriteLine();
iller.ForEach(i => Console.WriteLine(i));

iller.Remove("Ankara");
Console.WriteLine();
iller.ForEach(i=> Console.WriteLine(i));

Console.WriteLine();
sehirler.ForEach((s) => Console.WriteLine (s));



Console.ReadKey();
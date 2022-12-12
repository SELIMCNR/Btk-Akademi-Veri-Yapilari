// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Dışardan veri alma string değer döndürür
/*
var ifade = Console.ReadLine();
Console.WriteLine(ifade);*/

int n = 3;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j <=i; j++)
	{
		Console.WriteLine("{0,5}","*");
		Console.WriteLine();
	}
}
Console.ReadKey();
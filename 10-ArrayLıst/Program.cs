// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

//Array List tanımlama

var arrayList = new ArrayList();

// Tanım ve ekleme
var arrayList1 = new ArrayList(){  // liste oluşturma ve ekleme
    10,"Btk Akademi",true,"e"
};

// ekleme yapma
arrayList.Add(10);
arrayList.Add("BTK Akademi");
arrayList.Add(true);
arrayList.Add("e");

int[] sayilar = new int[] { 23, 44, 55 };
arrayList.AddRange(sayilar); // listeye diziden rastgele sayı eklme

//Dolaşma 
Console.WriteLine();
foreach (var e in arrayList)
{
    Console.Write($"{e}");
}
Console.WriteLine();
Console.WriteLine(arrayList[4]); // elemana erişim






// elemana erişim - atama
int x = (int)arrayList[0];
Console.WriteLine(x + 10);
Console.ReadKey();

// Elaman silme 
arrayList.Remove(10); // içine yazılan elemanı siler 
arrayList.RemoveAt(1); // indise göre siler
arrayList.RemoveRange(3, 3); // 3.indisten başla 3 eleman sil  
//Dolaşma 
Console.WriteLine();
foreach (var e in arrayList)
{
    Console.Write($" {e} ");
}


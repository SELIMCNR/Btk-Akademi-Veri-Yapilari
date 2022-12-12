// See https://aka.ms/new-console-template for more information
int x = 15;
int [] Seri = new int[] { 70, 80, 90 }; // seri eleman dizisi
   // List Tanımlama // referans tipli veri 
List<int> numbers = new List<int>();  // referans tipli verilerde new kullanılır.
  //2.yöntem list tanımlama
var sayilar = new List<int>();

//3.yöntem tanımlama ve ekleme
var numbers1 = new List<int>() { 10, 15, 20 };

// ekleme yapma
sayilar.Add(10);
sayilar.Add(15);
sayilar.Add(20);
sayilar.Add(x); // değişken ekledik
sayilar.AddRange(Seri); // diziyi listeye ekledik
sayilar.AddRange(new int[] { 40, 50, 60, 70, 80 });

// araya ekleme yapma
sayilar.Insert(3, 0); // 3. indise 0 elemeanını ekle
sayilar.InsertRange(4, new int[] { 80, 90 }); // 4.indsten itibaren dizi elemanlarını rastgele ekle

//Listeden eleman silme
sayilar.RemoveAt(3);
sayilar.RemoveAt(sayilar.IndexOf(10));//Dinamik silme işlemi 55.indekste elemanı sil
                                      // dolaşma
foreach (int n in sayilar)
{
    Console.Write($"{n,-5}");
}



Console.ReadKey();



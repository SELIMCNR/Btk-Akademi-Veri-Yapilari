/*
 List <T>
 
-Liste oluşturmak üzere kullanılır 
-Type -> T  - > Yer tutucu 
-> List <int>  integer değerlerden oluşan bir liste, tüm metotlar inte göre çalışacak
-Tip güvenliği  "Type-Safe" 
 */


//Liste tanımlama
List<int> sayilar = new List<int> ();

int x = 50;

int[] Seri = new int[] { 70, 80, 90 };
//listeye eleman ekleme
sayilar.Add (10);
sayilar.Add (20);
sayilar.Add(25);
sayilar.Add (x); //değişken üzerinden değer eklendi
sayilar.AddRange (Seri); //dizi üzerinden değerler eklendi
sayilar.AddRange (new int[] { 5,4,95});

//Araya değerler eklem
sayilar.Insert(0, 1907); // 0.indise ekle 1907
sayilar.InsertRange(4, new int[] { 75, 85 });

//Belirtilen değerleri silme
sayilar.RemoveAt(3); //3.indisde elemanı sil
sayilar.RemoveAt (sayilar.IndexOf(50));  //50 değerinin indisini bul ve sil


//Dolaşma listede
foreach (int li in sayilar)
{
    Console.WriteLine($"{li,-5}");
}

//Pratik yöntem liste tanımlama atama
var numbers = new List<int>() {10,15,20};


Console.ReadKey();



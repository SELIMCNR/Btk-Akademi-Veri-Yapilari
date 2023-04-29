/*
 ArrayList  ve  List <T>

--Diziler sabit boyutludur ancak ArrayList yapısının boyutu 
dinamik olarak artırılabilir.

-ArrayList bir koleksiyondur 
using System. ile projeye eklenir.
Add(),AddRange(),Clear(),Contains gibi metotları var ve capacity ,count  gibi özellikleri var.
 */

//Tanımlama
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();

        //Listeye ekleme 
        arrayList.Add(10);
        arrayList.Add("btk akademi");
        arrayList.Add(true);
        arrayList.Add('e');

        //Listede dolaşım görüntüleme
        foreach (var arlist in arrayList)
        {
            Console.WriteLine($"{arlist}");
        }

        //Listeye dizi ekleme
        int[] numbers = new int[] { 23, 44, 55 };
        arrayList.AddRange(numbers); //listeye diziyi ekle
        Console.WriteLine();

        //Listede dolaşım görüntüleme
        foreach (var arlist in arrayList)
        {
            Console.WriteLine($"{arlist}");
        }
        Console.WriteLine();
        //Listedeki elemana indise göre erişim
        Console.WriteLine(arrayList[4]);

        //Listedeki elemana erişme ve atama değer değiştirme
        int x = (int)arrayList[0];
        Console.WriteLine(x + 10);

        //Listedeki elemanı silme
        arrayList.Remove(10);  //değeri 10 olanı sil
        arrayList.RemoveAt(1); //1.indiste elemanı sil
        arrayList.RemoveRange(3, 5); // 3ile 5 arasında değerleri sil



        //Pratik yöntem  tanımlama ve ekleme
        var arrayList2 = new ArrayList()
{
    10,"Btk",false,'f'
};
        Console.WriteLine(arrayList2[2]);



        Console.ReadKey();
    }
}

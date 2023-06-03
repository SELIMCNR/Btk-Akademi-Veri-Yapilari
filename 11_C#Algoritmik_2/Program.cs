/*1 ile 1000 arasındaki tek ve çift sayıları yazdıran program*/
Console.WriteLine("1 ile 1000 arasındaki tek ve çift sayıları yazdıran program");
Console.WriteLine(new String('*',50));
Console.WriteLine();


for (int i = 0; i < 1000; i++)
{
    if(i%2 == 0)
    {
        Console.WriteLine("Sayi cifttir {0}",i);
    }
    else
    {
        Console.WriteLine("Sayi tektir {0}",i);
    }
}




/*1 ile girilen sayi arasındaki 3 ve 5 'e bölünen sayıları yazdıran program*/
Console.WriteLine("1 ile girilen sayi arasındaki 3 ve 5 'e bölünen sayıları yazdıran program");
Console.WriteLine(new String('*', 50));
Console.WriteLine();

Console.WriteLine("Sayi gir: ");
int sayi = int.Parse(Console.ReadLine());
for (int i = 1;i < sayi; i++)
{
    if(i % 3 == 0 && i%5==0) {

        Console.WriteLine("3 ve 5 ile tam bölünen sayı : {0}",i);
    }
    else
    {
        Console.WriteLine("3 ve 5 ile tam bölünmez");
    }
}
Console.WriteLine();

/*Girilen pozitif sayının faktoriyelini hesaplayan program*/
Console.WriteLine("Girilen pozitif sayının faktoriyelini hesaplayan program");
Console.WriteLine("Sayi gir : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(new String('*', 50));
Console.WriteLine();
int toplam = 1;

for (int sayac = 1; sayac <= n; sayac++)
{
    toplam  = toplam * sayac;

}
Console.WriteLine("{0} sayi ve faktoriyeli {1}",n,toplam);
Console.WriteLine();
/*Derece cinsinden girilen bir açıyı, Radyan ve Grad cinsine çeviren algoritma ve program*/
Console.WriteLine("Derece cinsinden girilen bir açıyı, Radyan ve Grad cinsine çeviren algoritma ve program");
Console.WriteLine("Derece gir : ");
int derece = int.Parse(Console.ReadLine());
Console.WriteLine(new String('*', 50));
Console.WriteLine();
float pi = 3.14f;
double radyan = derece * pi / 180;
double gradyan = derece * pi / 200;

Console.WriteLine("{0} derece {1} radyandır ",derece,radyan);
Console.WriteLine("{0} derece {1} gradyandır",derece,gradyan);


/* Girilen bir sayının mutlak değerini hesaplayan ve sonucu ekrana yazdıran program*/

Console.WriteLine("Girilen bir sayının mutlak değerini hesaplayan ve sonucu ekrana yazdıran program");
Console.WriteLine("Sayı gir : ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(new String('*', 50));
Console.WriteLine();
int mutlak = 0;
if(number < 0)
{
    mutlak = number * (-1);
    Console.WriteLine("{0} sayının mutlak değeri {1}",number,mutlak);
}
else
{
    Console.WriteLine("Sayı : {0}",number);
}


/*1 'den girilen sayıya kadar olan çift sayıların toplamını yapan program*/
Console.WriteLine("Sayı gir");
int number1 = Convert.ToInt32(Console.ReadLine());
int sayac1 = 1;
int ciftSayac2 = 1;
int toplam1 = 0;

for(sayac1 = 1; sayac1 < number1; sayac1++) {
    if(sayac1 % 2 == 0)
    {
        toplam1 += sayac1;
        ciftSayac2++;
    }
    else
    {
        Console.WriteLine("Sayı tek");
    }
}
Console.WriteLine("{0} bu kadar çift sayının toplamı : {1}",ciftSayac2,toplam1);









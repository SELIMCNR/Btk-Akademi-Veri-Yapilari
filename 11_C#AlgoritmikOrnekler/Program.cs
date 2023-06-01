




#region İlk örnek soru
/* Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp toplam sonucu ekrana yazdıran program*/
Console.WriteLine(" Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp toplam sonucu ekrana yazdıran program.");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(new String('-',50));
Console.WriteLine("Sayı 1 : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayı 2 : ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayı 3 : ");
int number3 = Convert.ToInt32(Console.ReadLine());
Maxmınsum(number1, number2, number3);
#endregion


#region İkinci örnek soru

/*Maaşı ve zam oranı girilen işçinin zamlı maaşını hesaplayarak ekranda gösteren C# örneği:*/
Console.WriteLine("*Maaşı ve zam oranı girilen işçinin zamlı maaşını hesaplayarak ekranda gösteren C# örnek program.");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(new String('-', 50));
Console.WriteLine("Mass : ");
int maas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zam oranı : ");
double zamOranı = Convert.ToDouble(Console.ReadLine());
var zamlımass = maas * zamOranı;
Console.WriteLine("Zamlı maas : {0}",zamlımass);
#endregion

#region ücüncü örnek soru

/*Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.*/

Console.WriteLine("Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan program.");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(new String('-', 50));
string taksi ="Taksi";
int taksi1Saat = 5;
double taksiartanOdemeOranı = 0.20;
string minübüs="Minübüs";
int minübüs1Saat = 6;
double minübüsartanOdemeOranı = 0.21;
string ticariArac="TicariArac";
double ticariArac1Saat = 6.5;
double ticariartanOdemeOranı = 0.25;

Console.WriteLine("Araba tipi : ");
string arabatipi = Console.ReadLine();
Console.WriteLine("Kalınan saat : ");
int kalınanSaat = Convert.ToInt32(Console.ReadLine());
var ücret = 0.0;

if (arabatipi == taksi)
{
    if (kalınanSaat < 1)
    {
        ücret = 0;
    }
    else if(kalınanSaat==1)
    {
        ücret = taksi1Saat;
    }
    else if (kalınanSaat < 6)
    {
        ücret = (taksiartanOdemeOranı * 6.0) + taksi1Saat;
    }
    else if (kalınanSaat < 24)
    {
        ücret = (  taksiartanOdemeOranı * 23.0) + taksi1Saat;
    }
    else if (kalınanSaat < 48)
    {
        ücret = (taksiartanOdemeOranı * 27.0) + taksi1Saat;
    }

}
if (arabatipi == minübüs)
{
    if (kalınanSaat < 1)
    {
        ücret = 0;
    }
    else if (kalınanSaat ==1)
    {
        ücret = minübüs1Saat;
    }
    else if (kalınanSaat < 6)
    {
        ücret = (minübüsartanOdemeOranı * 5.0) + minübüs1Saat;
    }
    else if (kalınanSaat < 24)
    {
        ücret = (minübüsartanOdemeOranı * 23.0) + minübüs1Saat;
    }
    else if (kalınanSaat < 48)
    {
        ücret = (minübüsartanOdemeOranı * 47.0) + minübüs1Saat;
    }
   
}
if (arabatipi == ticariArac)
{
    if (kalınanSaat < 1)
    {
        ücret = 0;
    }
    else if (kalınanSaat ==1)
    {
        ücret = ticariArac1Saat;
    }
    else if (kalınanSaat < 6)
    {
        ücret = (ticariartanOdemeOranı * 5.0) + ticariArac1Saat;
    }
    else if (kalınanSaat < 24)
    {
        ücret = (ticariartanOdemeOranı * 23.0) + ticariArac1Saat;
    }
    else if (kalınanSaat < 48)
    {
        ücret = (ticariartanOdemeOranı * 47.0) + ticariArac1Saat;
    }
  
}
Console.WriteLine("Ucret tutarı : {0}", ücret);


#endregion
void Maxmınsum(int a, int b, int c)
{
    int sum=0;
    if (a > b && a>c )
    {
        sum += a;
        if(c< b )
        {
            sum+=c;
        }
        else if(b< c )
        {
            sum += b;
        }
    }
    else if (b > a && b>c )
    {
        sum += b;
        if (c < a)
        {
            sum += c;
        }
        else if (a < c)
        {
            sum += a;
        }
        
    }
    else if(c>a && c>b )
    {
        sum += c;
        if (a < b)
        {
            sum += a;
        }
        else if (b < a)
        {
            sum += b;
        }
    }
    Console.WriteLine("Büyük küçük sayı toplamı : {0}",sum);


}
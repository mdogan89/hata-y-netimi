// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


try
{

    Console.WriteLine("Bir sayı giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("sayi: " + sayi);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
	
}
finally
{
    Console.WriteLine("işlem tamamlandı");
}


try
{
    int a = int.Parse("10000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("bos deger girdiniz");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message.ToString());
}
catch (OverflowException ex)


{

    Console.WriteLine("Cok kücük ya da büyük bir deger girdiniz");
    Console.WriteLine(ex.Message.ToString());
}
finally { Console.WriteLine("islem tamamlandı"); }


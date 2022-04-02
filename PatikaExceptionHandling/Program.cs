using System;

namespace PatikaExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {       ///hata alma ihtimali olan kod bloğunu giriyoruz
                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş olduğunuz sayi :"  + sayi);
            }
            catch (Exception ex)
            { //hatayı yakaladığımızda yapılacak şeyler
                Console.WriteLine("Hata :  "+ex.Message.ToString());
                
            }
            finally
            {   //hata alsakta almmasakta çalışan yer (zorunlu değil)
                Console.WriteLine("işlem tamamlandı.");
            }
            Console.WriteLine("===========================================");
            try
            {
            //    int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (OverflowException ex)
            //catch(ArgumentNullException ex)
            //catch (FormatException ex)
            {
                //Console.WriteLine("Veri TİPİ UYGUN DEĞİL");
                Console.WriteLine("ÇOK Küçük ya da çok büyük bir değer girdiniz");

                Console.WriteLine(ex);
            }
            finally
            {  
                Console.WriteLine("işlem tamamlandı.");
            }
        }
    }
}

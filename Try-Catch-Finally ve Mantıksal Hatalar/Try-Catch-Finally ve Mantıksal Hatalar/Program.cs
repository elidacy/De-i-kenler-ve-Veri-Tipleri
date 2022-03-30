using System;

namespace Try_Catch_Finally_ve_Mantıksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            try //hata alması muhtemel kontrol altına alabileceğimiz kodları
            {
                Console.WriteLine("bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş olduğunuz sayı:" + sayi);
            }
            catch(Exception ex) //hatayı yakaldığınızda ne yapmak istiyorsanız
            {
                Console.WriteLine("hata:" + ex.Message.ToString());
            }

            /* finally //hattadan bağımsız zorunlu değil
             {
                 Console.WriteLine("işlem tamamlandı.");
             }*/

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("çok küçük yada çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally { Console.WriteLine("işlem başarıyla tamamlandı")};

        }






        }
    }
}

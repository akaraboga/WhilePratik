using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

            int i=1;    
            while (i != 11)
            {
                Console.WriteLine(i+"-Yazılım işini hallederim");
                i++;
               
            }

            */



            /*
                int i = 1;

                while(i <=20)
                {
                    Console.WriteLine(i);
                    i++;
                }
            */


            /*
                int i = 1; //Dögüde donecek olan değeri tanımlıyoruz
 
                while(i <= 20)//hangi sayıya kadar döneceğini donguye yazdık
                {
                    if(i % 2 == 0)//eğer i değeri 2 ile tam bolunuyorsa i yi ekrana yazdırıyoruz
                    {
                        Console.WriteLine("Birden 20 ye kadar olan çift sayilar :"+i);
                    }
                    i++;
                }

                */



            /*

            float i = 50;
            float toplam = 0;  

            while (i <= 150)
            {
                toplam += i;

                i++;
            }
            Console.WriteLine("50 ile 150 arasındaki sayıların toplamı :" + toplam);

            */

            int i = 1; 

            int TekSayi = 0; // Döngünün içinde  i nin bolumunden kalana göre tek sayimi , çift sayimi olduğunda artacak olan değişkenleri alıyoruz
            int ÇiftSayi =0;

            while (i <= 120)
            {

                if(i % 2 == 0)//2 ile bolumunden kalan 0 ise çiftsayi değişkeni ile i yi topluyoruz 
                {
                    ÇiftSayi += i;
                }
                else//değilse teksayi topluyoruz
                {
                    TekSayi += i;
                }

                i++;
            }

            Console.WriteLine("Tek sayilarin toplamı :"+TekSayi);//toplama işlemlerini ekrana yazdıralım
            Console.WriteLine("Çift sayilarin toplamı :"+ÇiftSayi);

            Console.ReadLine();
        }
    }
}

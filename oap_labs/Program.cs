
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oap_labs
{
    class Program
    {
        static void Main(string[] args)
        {

          
             var Massiv = new int[10];

          
             Random Rand = new Random();

     
             for (int i = 0; i < Massiv.Length; i++)
               Massiv[i] = Rand.Next(100);

             var Massive = new int[10];
              Random Rand = new Random();
              var MaxValue = -1;


              for (int i = 0; i < Massive.Length; i++)
               {
                  Massive[i] = Rand.Next(100);
                   if (Massive[i] > MaxValue) 
                      MaxValue = Massive[i];
                  Console.Write($"{Massive [i]}\t");
              }
              Console.Write($"\nMaximum = {MaxValue}");

            var Massive = new int[10];
              Random Rand = new Random();
             var Summa = 0;
             var Proizvedenie = 1L;
             for (int i = 0; i < Massive.Length; i++)
             {
                 Massive[i] = Rand.Next(100);
                 Summa += Massive[i];
                 Proizvedenie = Proizvedenie * Massive[i];
                 Console.Write($"{Massive[i]}\t");
               }
                 Console.Write($"\nsumma = {Summa}\nпроизведение = {Proizvedenie}");
             Console.ReadLine();

             Console.Write("input MinValue: ");
             var MinValue = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input MaxValue: ");
            var MaxValue = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input Shag: ");
             var Shag = Convert.ToInt32(Console.ReadLine());
             for (int i = MinValue; i <= MaxValue; i += Shag)
             {
                 Console.Write($"{i}\t");
              }

             Console.Write("Введите число: ");
              var chislo = Convert.ToDouble(Console.ReadLine());
              var Factorial1 = 1;
              for (int i =2; i<= chislo; i++)
              {
                  Factorial1 = Factorial1 * i;
                   Console.Write($"{Factorial1}\t");
              }
             Console.Write($"\nФакориал равен = {Factorial1}\t");

                 var Massiv = new int[10];
               Random Rand = new Random();
                for (int i = 0; i < 10; i++)
               {
                  Massiv[i] = Rand.Next(100);
                   if (Massiv[i] % 2 == 0)
                      Console.Write("\n{0} - чет", Massiv[i]);
                  else
                       Console.Write("\n{0} - нечет", Massiv[i]);
               }

               Console.ReadLine();

        }

    }

}


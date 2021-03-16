
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
            Exercise();
            Exercise1();
            Exercise2();
        }
        static void Exercise()
        {
            Console.WriteLine("Введите строку для поиска времени: ");
            var InpString = Console.ReadLine();
            Regex RegexExpretion = new Regex(@"([0][1-9]|[1][0-9]|[2][0-3]):([0-5][0-9])");
            var Result = RegexExpretion.Match(InpString);

            if (RegexExpretion.IsMatch(InpString))
            {
                Console.WriteLine(Result.Value);
            }
            else
            {
                Console.WriteLine("неккоректное время");
            }


            Console.ReadKey();
        }
        static void Exercise1()
        {
            Console.WriteLine("Введите строку для поиска html цвета: ");
            var InpString = Console.ReadLine();
            Regex RegexExpretion = new Regex(@"#([0-9]|[A-F]){6}");
            var Result = RegexExpretion.Match(InpString);

            if (RegexExpretion.IsMatch(InpString))
            {
                Console.WriteLine(Result.Value);
            }
            else
            {
                Console.WriteLine("неккоректный цвет");
            }
            Console.ReadKey();
        }
        static void Exercise2()
        {
            Console.WriteLine("Введите строку для поиска арифметических операций: ");
            var InpString = Console.ReadLine();
            Regex RegexExpretion = new Regex(@"([-+]?(?:\d+(?:\.\d*)?|\.\d+)(?:[eE][-+]?\d+)?)([+]|[-]|[*][\/]?)([-+]?(?:\d+(?:\.\d*)?|\.\d+)(?:[eE][-+]?\d+)?)");
            var Result = RegexExpretion.Match(InpString);

            if (RegexExpretion.IsMatch(InpString))
            {
                Console.WriteLine(Result.Value);
            }
            else
            {
                Console.WriteLine("неккоректная строка");
            }
            Console.ReadKey();

        }
    }

    internal class Regex
    {
        private string v;

        public Regex(string v)
        {
            this.v = v;
        }

        internal bool IsMatch(string inpString)
        {
            throw new NotImplementedException();
        }

        internal object Match(string inpString)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Credit
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Расчет аннуитетной выплаты годового кредита");
            
                decimal a, b, c, m; 
                Console.Write("Ведите сумму кредита: "); a = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Введите процентную ставку: "); b = Convert.ToDecimal(Console.ReadLine());

                c = a + (a*b/100);
                m = c / 12;

                Console.Write("Ежемесячный платеж составит: " + m);
                Console.WriteLine();
                Console.Write("Общая сумма выплат составит: " + c);
                Console.ReadLine();


        }

    }
}

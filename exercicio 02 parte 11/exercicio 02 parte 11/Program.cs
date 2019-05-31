using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02_parte_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, divicao;
            Console.WriteLine("Digite o valor para A; ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor para B; ");
            y = int.Parse(Console.ReadLine());

            if (y != 0)

            {
                divicao = x / y;

            }
            else
            {
                Console.WriteLine("não a divisão por zero. ");
            }
            Console.ReadKey();
                        
           

                
        }
    }
}

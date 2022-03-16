using System;

namespace Acrecimo_De_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, acrescimo;

            Console.WriteLine("Digite o salario : ");
            salario = double.Parse(Console.ReadLine());

            if (salario > 600)
            {
                acrescimo = salario * 0.4;
                salario = salario + acrescimo;
                Console.WriteLine("O acrescimo de salario eh {0} e o salario com acrescimo vai ser {1} ", acrescimo, salario);
            }
            else
            { 
                if ((salario <= 600) && (salario > 400))
                {
                    acrescimo = salario * 0.3;
                    salario = salario + acrescimo;
                    Console.WriteLine("O acrescimo de salario eh {0} e o salario com acrescimo vai ser {1} ", acrescimo, salario);
                }
                else  if ((salario <= 400) && (salario > 200))
                    {
                        acrescimo = salario * 0.2;
                        salario = salario + acrescimo;
                        Console.WriteLine("O acrescimo de salario eh {0} e o salario com acrescimo vai ser {1} ", acrescimo, salario);
                    }
                    else
                    {
                        Console.WriteLine("Não tem acrescimo de salario de salario então seu salari oeh {0} ", salario);
                    
                }
            }
        }
    }
}

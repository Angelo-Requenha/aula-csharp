namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Operadores de Comparação
                == : Igual a
                != : Diferente de
                > : Maior que
                < : Menor que
                >= : Maior ou igual a
                <= : Menor ou igual a

            2. Operadores Lógicos
                && : E lógico (AND)
                || : Ou lógico (OR)
                ! : Não lógico (NOT)
             */

            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Esolha um numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Esolha um numero:");
            num2 = int.Parse(Console.ReadLine());


            if (num1 > num2 && num1 != 10)
            {
                Console.WriteLine($"{num1} é maior q {num2} e não é 10");
            }
            else if (num1 == num2 || num2 <= 14)
            {
                Console.WriteLine($"Os numeros são iguais ou o segundo numero é {num2}");
            }
            else
            {
                Console.WriteLine($"{num2} é maior q {num1}");
            }
        }
    }
}

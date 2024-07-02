namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Operadores Aritméticos
                + : Adição
                - : Subtração
                * : Multiplicação
                / : Divisão
                % : Módulo (resto da divisão)

            2. Operadores de Incremento e Decremento
                ++ : Incremento
                -- : Decremento

            3. Operadores de Atribuição
                = : Atribuição
                += : Adição e atribuição
                -= : Subtração e atribuição
                *= : Multiplicação e atribuição
                /= : Divisão e atribuição
                %= : Módulo e atribuição

            4. Operadores de Comparação
                == : Igual a
                != : Diferente de
                > : Maior que
                < : Menor que
                >= : Maior ou igual a
                <= : Menor ou igual a

            5. Operadores Lógicos
                && : E lógico (AND)
                || : Ou lógico (OR)
                ! : Não lógico (NOT)
             */

            int num1 = 0;
            int num2 = 0;
            string operador = "";


            Console.WriteLine("Escolha um numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha outro numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha qual operador usar\nSoma +\nSubtração -\nDivisão /\nMultiplicação *");
            operador = Console.ReadLine();

            if (operador == "+") {
                Console.WriteLine($"A soma entre {num1} e {num2} é {num1+num2}"); 
            }
            else if (operador == "-")
            {
                Console.WriteLine($"A subtração entre {num1} e {num2} é {num1 - num2}");
            }
            else if (operador == "/")
            {
                Console.WriteLine($"A divisão entre {num1} e {num2} é {num1 / num2}");
            }
            else if (operador == "*")
            {
                Console.WriteLine($"A multiplicação entre {num1} e {num2} é {num1 * num2}");
            }

        }
    }
}

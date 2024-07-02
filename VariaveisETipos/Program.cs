namespace VariaveisETipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipo Nome = Valor \| Não é permitido alterar o tipo de uma vareavel

            /* 
                Int(numeros inteiros)
                Float(numeros com ponto flutuante) ===> Double \| Decimal
                Bool(true, false)
                String("Texto com aspas")
                Char("A" 1 caractere) 

                var Nome = Valor \| Não é necessario definir o tipo
                dynamic Nome = Valor \| Permite mudar o tipo
                const Tipo Nome = Valor \| Valor que nunca muda
            */

            string helloWorld = "Hello, World!";
            int numInt1 = 20;
            int numInt2 = 14;
            float numFloat1 = 3.14f;
            var semTipo = "Texto";
            bool comparador = false;
            dynamic mudarTipo = "Meu tipo vai mudar"; // Recomendado evitar
            const float PI = 3.14f;


            Console.WriteLine(helloWorld);
            Console.WriteLine(numInt1 + numInt2);
            Console.WriteLine(numFloat1 + numInt2);
            Console.WriteLine(semTipo);
            Console.WriteLine(mudarTipo);
            Console.WriteLine(PI); // Ultilizar por segurança, e evitar erros

            // if intruso para exemplificar o booleano
            if (numInt1 > (numInt2 + numFloat1)) { 
                comparador |= true;
            }
            Console.WriteLine(comparador);

            mudarTipo = 14.8f;
            Console.WriteLine(mudarTipo);
        }
    }
}

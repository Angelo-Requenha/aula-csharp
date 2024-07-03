namespace EstruturaDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;


            while (contador < 10)
            {
                // contador = contador + 1
                // contador += 1
                contador++;
                Console.WriteLine(contador);
            }

            contador = 0;

            do {
                contador++;
                Console.WriteLine(contador);
            } while (contador < 10);
        }
    }
}

namespace ArrayEFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtos1 = new string[5] { // Pode definir a quantidade de itens
                "Deletado",
                "Produto2",
                "Produto3",
                "Produto4",
                "Produto5"
            };

            int[] produtos2 = { // Define a quantidade de itens baseado em quantos itens tem
                1,
                2,
                3,
                4,
                5
            };

            Console.WriteLine(produtos1[0]);
            produtos1[0] = "Produto1";
            Console.WriteLine(produtos1[0]);

            Console.WriteLine("------------------------");

            foreach (string t in produtos1) {  // For para arrays
                Console.WriteLine(t); 
            }

            Console.WriteLine("------------------------");

            for (int contador = 0; contador < produtos1.Length; contador++) {
                Console.Write($"{produtos2[contador]} - ");
                Console.WriteLine($"Produto{contador + 1}");
            }

            Console.WriteLine("------------------------");

            for (int contador = produtos2.Length - 1; contador >= 0 ; contador--)
            {
                Console.Write($"{produtos2[contador]} - ");
                Console.WriteLine($"Produto{contador + 1}");
            }

        }
    }
}

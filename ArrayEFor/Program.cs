namespace ArrayEFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtos1 = new string[5] { // Pode definir a quantidade de itens
                "Produto1",
                "Produto2",
                "Produto3",
                "Produto4",
                "Produto5"
            };

            string[] produtos2 = { // Define a quantidade de itens baseado em quantos itens tem
                "Produto1",
                "Produto2",
                "Produto3",
                "Produto4",
                "Produto5"
            };

            Console.WriteLine(produtos1[0]);
            produtos1[0] = "Deletado";
            Console.WriteLine(produtos1[0]);

            
            }
        }
    }
}

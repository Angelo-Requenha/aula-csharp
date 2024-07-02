namespace EntradaDoUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int num1 = 0;
            int num2 = 0;


            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digte um numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Pois é {nome}, {num1}+{num2} não é {num1 - num2}");
        }
    }
}

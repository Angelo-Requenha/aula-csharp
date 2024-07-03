namespace ChamandoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Angelo", 21);

            Console.WriteLine(pessoa1.Exibir());
        }
    }
}

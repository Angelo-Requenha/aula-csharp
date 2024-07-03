namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float preco = 0;
            float porcentagem = 0;
            float resultado = 0;

            
            Console.WriteLine("Digite o preço: ");
            preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de desconto: ");
            porcentagem = float.Parse(Console.ReadLine());

            ExibirMsg();
            resultado = GerarDesconto(preco, porcentagem);
            Console.WriteLine($"O valor com desconto é {resultado}");
        }

        static void ExibirMsg() // Void serve para função sem retorno
        {
            Console.WriteLine("Bom dia flores do dia");
        }

        static float GerarDesconto(float p, float d) // No lugar de void, deve-se colocar o tipo do valor retornado
        {
            float valorFinal = Math.Abs(p) * (d / 100); // Math.Abs(variavel) serve para converter valores negativos para positivos
            return valorFinal; // Retorna um valor
        }

    }
}

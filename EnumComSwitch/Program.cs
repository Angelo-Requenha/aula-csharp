namespace EnumComSwitch
{
    internal class Program
    {
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer: Criar");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Você quer: Deletar");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Você quer: Editar");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Você quer: Listar");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Você quer: Atualizar");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada");
                    break;
            }


        }
    }
}

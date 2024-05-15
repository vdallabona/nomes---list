namespace Batata
{
    public class Pessoa
    {

        public static void Main()
        {
            string op;
            do
            {
                Console.WriteLine("1 - Criar nome");
                Console.WriteLine("2 - Ler nome");
                Console.WriteLine("3 - Atualizar nome");
                Console.WriteLine("4 - Deletar nome");
                Console.WriteLine("5 - Sair");
                op = Console.ReadLine() ?? "";

                switch (op)
                {
                    case "1":
                        EditarLista.CriarNome();
                        break;

                    case "2":
                        EditarLista.LerNomes();
                        break;

                    case "3":
                        EditarLista.AlterarNomes();
                        break;

                    case "4":
                        EditarLista.DeletarNomes();
                        break;

                    case "5":
                        Console.WriteLine("Saindo.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (op != "5");
        }
    }
}
namespace Batata
{
    public class EditarLista
    {
        static List<string> itens = [];
        static List<int> indexDeletados = [];
        public static void CriarNome()
        {
            Console.WriteLine("Digite um nome: ");
            string nome = Console.ReadLine() ?? "";
            itens.Add(nome);
            Console.WriteLine($"O nome {nome}, foi adicionado com sucesso.");
        }
        public static void LerNomes()
        {
            if (itens.Count > 0)
            {
                Console.WriteLine("------------- Os nomes cadastrados são -------------");
                foreach (string item in itens)
                {
                    Console.Write(item);
                    Console.WriteLine($" índice - {itens.IndexOf(item)}");
                }
                Console.WriteLine("----------------------------------------------------");
                //  itens.ForEach(Console.WriteLine); Também dava pra fazer desse jeito que é menor
            }
            else
            {
                Console.WriteLine("Lista de nome está vazia.");
            }
        }
        public static void AlterarNomes()
        {
            Console.WriteLine("Informe o índice do nome para alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            if (indice >= 0 && indice < itens.Count)
            {
                Console.WriteLine("Digite o novo nome: ");
                string novoNome = Console.ReadLine() ?? "";
                string nomeAntigo = itens[indice];
                itens[indice] = novoNome;
                Console.WriteLine($"Nome alterado de {nomeAntigo} para {itens[indice]}.");
            }
            else
            {
                Console.WriteLine("Indice inválido.");
            }
        }
        public static void DeletarNomes()
        {
            indexDeletados.Clear(); // limpar a lista caso o usuário delete mais de uma vez
            int deletado;
            int op;
            Console.WriteLine("------------- Os nomes cadastrados são -------------");
            foreach (string item in itens)
            {
                Console.Write(item);
                Console.WriteLine($" índice - {itens.IndexOf(item)}");
            }
            Console.WriteLine("----------------------------------------------------");
            do{
                Console.WriteLine("Informe o índice do nome para deletar: ");
                int indice = Convert.ToInt32(Console.ReadLine());
                if (indice >= 0 && indice < itens.Count)
                {
                    string nomeDeletado = itens[indice];
                    indexDeletados.Add(indice);
                    Console.WriteLine($"Nome {nomeDeletado} será deletado.");
                }
                else
                {
                    Console.WriteLine("Indice inválido.");
                }
                Console.WriteLine("Deseja deletar outro nome?");
                Console.WriteLine("[1] - Sim");
                Console.WriteLine("[2] - Não");
                op = Convert.ToInt32(Console.ReadLine());
            }while(op == 1);
            indexDeletados.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(indexDeletados);
            for (int i = 0; i < indexDeletados.Count; i++)
            {
                deletado = indexDeletados[i];
                Console.WriteLine($"Deletando o nome ");
                Console.WriteLine(itens[deletado]);
                itens.RemoveAt(deletado);
            }
        }
    }
}
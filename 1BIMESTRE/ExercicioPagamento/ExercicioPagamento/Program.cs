namespace ExercicioPagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de folha de pagamento. Digite seus dados:");
            FolhaPagamento folha1 = new FolhaPagamento();
            folha1.EmissaoDados();
            Console.WriteLine("Essa é sua folha salarial:");
            Console.WriteLine(folha1.EmissaoFolha());
        }
    }
}

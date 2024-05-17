namespace areaQuadradoRETAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO DE AREA DE QUADRADO OU RETANGULO");
            AREA area = new AREA();
            Console.WriteLine("Digite o valor de sua base:");
            area.Base = Console.ReadLine();
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o valor da altura:");
            area.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area:" + )



            area.MostraDetalhes();



        }
    }
}
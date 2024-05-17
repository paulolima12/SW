namespace Aviao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aviao aviao1 = new Aviao();
            aviao1.inicializar();
            aviao1.aumentar();
            aviao1.descer();
            aviao1.definir("Boeing", "737");
            Console.WriteLine("O Modelo é: " + aviao1.marcaAtual() + " e seu modelo é: " + aviao1.modeloAtual());
            Console.WriteLine("A velocidade do Avião1 é de: " + aviao1.velocidadeAtual() + " km/h.");
            Console.WriteLine("A altitude do Avião1 é de: " + aviao1.altitudeAtual() + " metros.");

            Aviao aviao2 = new Aviao();
            aviao2.inicializar();
            aviao2.reduzir();
            aviao2.subir();
            aviao2.definir("Airbus", "A320");
            Console.WriteLine("A marca do Avião2 é: " + aviao2.marcaAtual() + " e seu modelo é: " + aviao2.modeloAtual());
            Console.WriteLine("A velocidade do Avião2 é de: " + aviao2.velocidadeAtual() + " km/h.");
            Console.WriteLine("A altitude do Avião2 é de: " + aviao2.altitudeAtual() + " metros.");

            Console.ReadKey();

        }
    }
}

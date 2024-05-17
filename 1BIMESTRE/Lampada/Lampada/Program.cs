namespace Lampada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada lamp1 = new Lampada();

            lamp1.ligar();
            lamp1.desligar();
            Console.WriteLine("A lâmpada está ligada? " + lamp1.estaLigada());

            Console.WriteLine("Digite a cor da lâmpada.");
            lamp1.definirCor();
            Console.WriteLine("A cor da lâmpada é: " + lamp1.corAtual());

            lamp1.potenciaBaixa();
            lamp1.potenciaAlta();
            Console.WriteLine("A potência da lâmpada é de: " + lamp1.potenciaAtual());
        }
    }
}

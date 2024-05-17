namespace Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();

            Console.WriteLine("Bem vindo ao Banco do Paulin Lindo!");
            Console.WriteLine("CONSULTANDO O SALDO...");
            conta1.consulta_saldo();

            Console.WriteLine("DEPÓSITO DE R$ 1000,35");
            conta1.depositar(1000.35);
            Console.WriteLine("O SALDO...");
            conta1.consulta_saldo();

            //Console.WriteLine("EFETUANDO UM SAQUE DE R$ 15,99");
            //conta.sacar(500);
            //Console.WriteLine("CONSULTANDO O SALDO...");
            //conta.consulta_saldo();

            //Console.WriteLine("EFETUANDO UM SAQUE DE R$ 45,99");
            //conta.sacar(1200);

            conta1.ajusta_limite(1000);
            conta1.consulta_saldo();
            Console.WriteLine("REALIZANDO SAQUE DE R$ 3000,00");
            conta1.sacar(3000);
            conta1.consulta_saldo();
        }
    }
}

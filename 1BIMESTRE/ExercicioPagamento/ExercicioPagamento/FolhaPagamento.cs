using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerPagamento
{
    public class FolhaPagamento
    {
        private string? Nome { get; set; }
        private float Salario { get; set; }
        private int HEDiurna { get; set; }
        private int HENoturna { get; set; }
        private int NumDependente { get; set; }
        private int Faltas { get; set; }
        private float DescontoEvent { get; set; }
        private float GastoRefeicao { get; set; }
        private int Vales { get; set; }

        public void EmissaoDados()
        {
            Console.WriteLine("Digite seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Digite seu salário:");
            Salario = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------");
            Console.WriteLine("Digite a quantidade de horas extras diurnas:");
            HEDiurna = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------");
            Console.WriteLine("Digite a quantidade de horas extras noturnas:");
            HENoturna = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------");
            Console.WriteLine("Digite o valor gasto em refeições:");
            GastoRefeicao = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------");
            Console.WriteLine("Digite a quantidade de vales utilizados:");
            Vales = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------");
            Console.WriteLine("Digite o valor de descontos eventuais:");
            DescontoEvent = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------");
            Console.WriteLine("Digite a quantidade de dependentes:");
            NumDependente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------");
        }

        public string EmissaoFolha()
        {
            double HoraExtra = (HEDiurna * (Salario / 160)) + (HENoturna * 1.2 * (Salario / 160));
            double salFamilia = NumDependente * 0.05 * 1412;
            double salBruto = Salario + HoraExtra + salFamilia;
            
            double INAMPS = 0.08 * Salario;
            double descFalta = Faltas * (Salario / 160);
            double ImpostoDeRenda = 0.08 * salBruto;
            double DescontoTotal = INAMPS + descFalta + ImpostoDeRenda + DescontoEvent;
            double salLiquido = salBruto - DescontoTotal;

            return $"Nome: {Nome}\nSalário: {Salario}\nValor de horas extras: {HoraExtra}\nSalário família: {salFamilia}\nDesconto INAMPS: {INAMPS}\nFaltas: {Faltas}\nValor em refeições: {GastoRefeicao}\nVales utilizados: {Vales}\nDescontos eventuais: {DescontoEvent}\nImposto de renda: {ImpostoDeRenda}\nSalário líquido: {salLiquido}\nSalário bruto: {salBruto}";
        }
    }
}

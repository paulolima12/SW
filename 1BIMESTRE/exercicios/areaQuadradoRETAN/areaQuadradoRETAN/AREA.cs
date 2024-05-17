using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaQuadradoRETAN
{
    public class AREA
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int AreaCalculo { get; set; }

        public int Calcular()
        {
            AreaCalculo = Base * Altura;
            return AreaCalculo;

        }


        public string Calcular2()
        {
            string resultado = "";
            AreaCalculo = Base * Altura;

            if(Base ==Altura)
            {
                resultado = "Qradrado: " + AreaCalculo;

            }
            else
            {
                resultado = "retangulo " + AreaCalculo:
            }

            return resultado;

        }
        public void MostraDetalhas()
        {
            Console.WriteLine("Base: " + Base)
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Area: " + AreaCalculo);

        }
    }
}

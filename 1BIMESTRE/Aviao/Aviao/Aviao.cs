using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviao
{
    public class Aviao
    {
        private string Modelo { get; set; }
        private string Marca { get; set; }
        private int Velocidade { get; set; }
        private int Altitude { get; set; }

        public void inicializar()
        {
            Velocidade = 850;
            Altitude = 9000;
        }

        public void definir(string nomeDaMarca, string nomeDoModelo)
        {
            Marca = nomeDaMarca;
            Modelo = nomeDoModelo;
        }

        public string marcaAtual()
        {
            return Marca;
        }
        public string modeloAtual()
        {
            return Modelo;
        }

        public void reduzir()
        {
            Velocidade -= 70;
        }
        public void aumentar()
        {
            Velocidade += 70;
        }
        public int velocidadeAtual()
        {
            return Velocidade;
        }

        public void subir()
        {
            Altitude += 3000;
        }
        public void descer()
        {
            Altitude -= 3000;
        }
        public int altitudeAtual()
        {
            return Altitude;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFotos
{
    public class AlbumDeFotos
    {
        private int NumTotalDeFotos { get; set; }
        private int NumTotalDePags { get; set; }
        
        private int numFotos;

        public int NumFotos
        {
            get
            {
                return numFotos;
            }

            set 
            {
                if (value > NumTotalDeFotos)
                {
                    Console.WriteLine("Você excedeu o número de fotos. O album não pode ser criado.");
                }
                else
                {
                    numFotos = value;
                    Console.WriteLine("Album foi criado. Número de fotos permitido.");
                }
            }
        }
        
        public void CriarAlbum(int paginas, int fotos)
        {
            NumTotalDePags = paginas;
            NumTotalDeFotos = paginas * 2;
            NumFotos = fotos;

            Console.WriteLine("Número total de páginas: " + paginas);
            Console.WriteLine("Número total de fotos: " + NumTotalDeFotos);
            Console.WriteLine("Número de fotos a serem inseridas: " + fotos);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitub
{
    public class RetanguloView
    {
        public void MostrarRetangulo(Retangulo r) 
        {
            Console.WriteLine($"Retangulo de base {r.Base} e altura {r.Altura} tem area: {r.CalcularArea()} e perimetro: {r.CalcularPerimetro()}");
        }
    }
}

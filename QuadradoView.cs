using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitub
{
    public class QuadradoView
    {
        public void MostrarQuadrado(Quadrado q)
        {
            Console.WriteLine($"Quadrado de lado {q.Lado} tem perimetro: {q.Perimetro()}, area: {q.Area()} e diagonal: {q.Diagonal()}");
        }
    }
}

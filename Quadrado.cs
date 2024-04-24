using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitub
{
    public class Quadrado
    {

        // Varável _lado do quadrado
        private double _lado=1;

        public double Lado
        {
            get { return _lado; }
            set
            {
                if (value > 0)
                    _lado = value;
            }
        } 

        // Construtor vazio
        public Quadrado() {}

        // Construtor por parametros
        public Quadrado(double l) : base() { Lado = l; }

        // Construror copia
        public Quadrado(Quadrado q) {Lado = q.Lado; }



        // Função para calcular o perímetro do quadrado
        public double Perimetro()
        {
            return 4 * _lado;
        }

        // Função para calcular a área do quadrado
        public double Area()
        {
            return _lado * _lado;
        }

        // Função para calcular a diagonal do quadrado
        public double Diagonal()
        {
            return Math.Sqrt(2) * _lado;
        }
    }
}

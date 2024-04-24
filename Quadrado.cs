using System;

namespace ConsoleAppGitub
{
    /// <summary>
    /// Representa um quadrado e fornece métodos para calcular seu perímetro, área e diagonal.
    /// </summary>
    public class Quadrado
    {
        // Varável _lado do quadrado
        private double _lado = 1;

        /// <summary>
        /// Obtém ou define o comprimento do lado do quadrado.
        /// </summary>
        public double Lado
        {
            get { return _lado; }
            set
            {
                if (value > 0)
                    _lado = value;
            }
        }

        /// <summary>
        /// Inicializa uma nova instância da classe Quadrado com o lado definido como 1.
        /// </summary>
        public Quadrado() { }

        /// <summary>
        /// Inicializa uma nova instância da classe Quadrado com o lado especificado.
        /// </summary>
        /// <param name="l">Comprimento do lado do quadrado.</param>
        public Quadrado(double l) : base() { Lado = l; }

        /// <summary>
        /// Inicializa uma nova instância da classe Quadrado com base em outra instância de Quadrado (cópia).
        /// </summary>
        /// <param name="q">Instância de Quadrado a ser copiada.</param>
        public Quadrado(Quadrado q) { Lado = q.Lado; }

        /// <summary>
        /// Calcula o perímetro do quadrado.
        /// </summary>
        /// <returns>O perímetro do quadrado.</returns>
        public double Perimetro()
        {
            return 4 * _lado;
        }

        /// <summary>
        /// Calcula a área do quadrado.
        /// </summary>
        /// <returns>A área do quadrado.</returns>
        public double Area()
        {
            return _lado * _lado;
        }

        /// <summary>
        /// Calcula a diagonal do quadrado.
        /// </summary>
        /// <returns>O comprimento da diagonal do quadrado.</returns>
        public double Diagonal()
        {
            return Math.Sqrt(2) * _lado;
        }
    }
}

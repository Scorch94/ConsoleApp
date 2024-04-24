using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitub
{
    using ConsoleAppGitub;
    using System;

    /// <summary>
    /// Classe responsável por exibir informações sobre um retângulo.
    /// </summary>
    public class RetanguloView
    {
        /// <summary>
        /// Exibe as dimensões, área e perímetro de um retângulo.
        /// </summary>
        /// <param name="r">O retângulo a ser exibido.</param>
        public void MostrarRetangulo(Retangulo r)
        {
            Console.WriteLine($"Retângulo de base {r.Base} e altura {r.Altura} tem área: {r.CalcularArea()} e perímetro: {r.CalcularPerimetro()}");
        }
    }

}

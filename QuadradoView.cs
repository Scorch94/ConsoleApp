using System;

namespace ConsoleAppGitub
{
    /// <summary>
    /// Classe responsável por exibir informações sobre um objeto Quadrado.
    /// </summary>
    public class QuadradoView
    {
        /// <summary>
        /// Exibe as informações do quadrado, incluindo seu lado, perímetro, área e diagonal.
        /// </summary>
        /// <param name="q">Instância do quadrado a ser exibida.</param>
        public void MostrarQuadrado(Quadrado q)
        {
            Console.WriteLine($"Quadrado de lado {q.Lado} tem perimetro: {q.Perimetro()}, area: {q.Area()} e diagonal: {q.Diagonal()}");
        }
    }
}

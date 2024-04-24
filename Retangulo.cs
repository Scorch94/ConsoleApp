using ConsoleAppGitub;
using System;

/// <summary>
/// Representa um retângulo com dimensões especificadas.
/// </summary>
public class Retangulo
{
    private double _base;
    private double _altura;

    /// <summary>
    /// Inicializa uma nova instância da classe Retangulo com base e altura especificadas.
    /// </summary>
    /// <param name="bas">A base do retângulo. O padrão é 1.</param>
    /// <param name="alt">A altura do retângulo. O padrão é 1.</param>
    public Retangulo(double bas = 1, double alt = 1)
    {
        Base = bas;
        Altura = alt;
    }

    /// <summary>
    /// Obtém ou define a base do retângulo.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Lançada quando o valor da base é menor ou igual a zero.</exception>
    public double Base
    {
        get { return _base; }
        set
        {
            if (value > 0)
                _base = value;
            else
                throw new ArgumentOutOfRangeException("O valor da base deve ser maior que zero.");
        }
    }

    /// <summary>
    /// Obtém ou define a altura do retângulo.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Lançada quando o valor da altura é menor ou igual a zero.</exception>
    public double Altura
    {
        get { return _altura; }
        set
        {
            if (value > 0)
                _altura = value;
            else
                throw new ArgumentOutOfRangeException("O valor da altura deve ser maior que zero.");
        }
    }

    /// <summary>
    /// Inicializa uma nova instância da classe Retangulo com base e altura padrão.
    /// </summary>
    public Retangulo() { }

    /// <summary>
    /// Inicializa uma nova instância da classe Retangulo com base em outro retângulo.
    /// </summary>
    /// <param name="r">O retângulo a partir do qual serão copiadas as dimensões.</param>
    public Retangulo(Retangulo r) { Base = r.Base; Altura = r.Altura; }

    /// <summary>
    /// Calcula a área do retângulo.
    /// </summary>
    /// <returns>A área do retângulo.</returns>
    public double CalcularArea()
    {
        return _base * _altura;
    }

    /// <summary>
    /// Calcula o perímetro do retângulo.
    /// </summary>
    /// <returns>O perímetro do retângulo.</returns>
    public double CalcularPerimetro()
    {
        return 2 * (_base + _altura);
    }
}

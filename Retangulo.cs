using ConsoleAppGitub;
using System;

public class Retangulo
{
    private double _base;
    private double _altura;

    public Retangulo(double bas = 1, double alt = 1)
    {
        Base = bas;
        Altura = alt;
    }

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

    public Retangulo(Retangulo r) { Base = r.Base;, Altura = r.Altura; }

    public double CalcularArea()
    {
        return _base * _altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (_base + _altura);
    }
}


namespace ConsoleAppGitub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(5); // Criando um quadrado com lado de comprimento 5
            Console.WriteLine($"Perímetro do quadrado: {quadrado.Perimetro()}");
            Console.WriteLine($"Área do quadrado: {quadrado.Area()}");
            Console.WriteLine($"Diagonal do quadrado: {quadrado.Diagonal()}");
        }
    }
}
namespace ConsoleAppGitub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(4); // Criando um quadrado com lado de comprimento 5
            Console.WriteLine($"Perímetro do quadrado: {quadrado.Perimetro()}");
            Console.WriteLine($"Área do quadrado: {quadrado.Area()}");
            Console.WriteLine($"Diagonal do quadrado: {quadrado.Diagonal()}");

            try
            {
                double baseRetangulo = 5;
                double alturaRetangulo = 3;

                Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

                Console.WriteLine("Área do retângulo: " + retangulo.CalcularArea());
                Console.WriteLine("Perímetro do retângulo: " + retangulo.CalcularPerimetro());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu uma exceção: " + ex.Message);
            }
        }
    }
}
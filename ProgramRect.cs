namespace Rectangulo
{

    class ProgramRect
    {
        static void Main(string[] args)
        {
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
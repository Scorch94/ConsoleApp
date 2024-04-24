namespace ConsoleAppGitub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado modelQ = new Quadrado { Lado= 4};
            QuadradoView viewQ = new QuadradoView();

            QuadradoController controller = new QuadradoController(modelQ, viewQ);

            controller.AtualizarView();

            Retangulo modelR = new Retangulo { Base=4, Altura=3 };
            RetanguloView viewR = new RetanguloView();

            RetanguloController controllerR = new RetanguloController(modelR, viewR);

            controllerR.AtualizarView();



        }
    }
}
using CohesionAndCoupling.Engine;
using CohesionAndCoupling.Interfaces;
using CohesionAndCoupling.UI;

namespace CohesionAndCoupling
{
    public class BookStoreMain
    {
        public static void Main()
        {
            IRenderer renderer = new FileRenderer();
            IInputHandler inputHandler = new ConsoleInputHandler();

            BookStoreEngine engine = new BookStoreEngine(renderer, inputHandler);

            engine.Run();
        }
    }
}
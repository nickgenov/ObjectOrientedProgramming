using System;
using CohesionAndCoupling.Interfaces;

namespace CohesionAndCoupling.UI
{
    public class ConsoleRenderer : IRenderer
    {
        public void WriteLine(string message, params object[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}
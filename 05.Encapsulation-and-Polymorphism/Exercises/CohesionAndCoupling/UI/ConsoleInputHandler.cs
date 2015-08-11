using System;
using CohesionAndCoupling.Interfaces;

namespace CohesionAndCoupling.UI
{
    class ConsoleInputHandler : IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
using System.IO;
using CohesionAndCoupling.Interfaces;

namespace CohesionAndCoupling.UI
{
    public class FileRenderer : IRenderer
    {
        public void WriteLine(string message, params object[] parameters)
        {
            using (var writer = File.AppendText("../../output.txt"))
            {
                writer.WriteLine(message, parameters);
            }
        }
    }
}
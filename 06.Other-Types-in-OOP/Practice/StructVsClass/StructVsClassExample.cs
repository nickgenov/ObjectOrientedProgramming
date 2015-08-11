using System;

namespace StructVsClass
{
    class StructVsClassExample
    {
        private const long PixelCount = 1920 * 1080;

        static void Main()
        {
            long structStartMemory = GC.GetTotalMemory(true);
            ColorStruct[] structColors = new ColorStruct[PixelCount];

            for (int i = 0; i < structColors.Length; i++)
            {
                structColors[i] = new ColorStruct();
            }

            long structEndMemory = GC.GetTotalMemory(true);

            Console.WriteLine("{0} instances of struct: {1} KB", PixelCount, (structEndMemory - structStartMemory) / 1000);

            long classStartMemory = GC.GetTotalMemory(true);
            ColorClass[] classColors = new ColorClass[PixelCount];

            for (int i = 0; i < classColors.Length; i++)
            {
                classColors[i] = new ColorClass();
            }

            long classEndMemory = GC.GetTotalMemory(true);

            Console.WriteLine("{0} instances of class: {1} KB", PixelCount, (classEndMemory - classStartMemory) / 1000);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClasses
{
    class DefineClasses
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 10;
            rect.Height = 20;

            Rectangle rect2 = new Rectangle();
            rect2.Height = 100;
            rect2.Width = 200;

            Console.WriteLine("Rect ({0}, {1})", rect.Width, rect.Height);
            Console.WriteLine("Rect2 ({0} {1})", rect2.Width, rect2.Height);

            var rect3 = new Rectangle()
            {
                Width = 20,
                Height = 30
            };

            Console.WriteLine(rect3);
            rect3.Print();
            Console.WriteLine(rect3.Area);

            //Square square = new Square(-1); //exception - check in the property

            Square square = new Square(4);
            

        }
    }
}

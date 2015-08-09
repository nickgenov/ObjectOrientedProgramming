using System;
using Books.Classes;

namespace Books
{
    class ExcerciseOne
    {
        static void Main()
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90m);
            Console.WriteLine(book);

            GoldenEditionBook goldenBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90m);
            Console.WriteLine(goldenBook);
        }
    }
}
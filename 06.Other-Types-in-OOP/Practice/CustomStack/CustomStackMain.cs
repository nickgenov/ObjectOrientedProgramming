using System;

namespace CustomStack
{
    class CustomStackMain
    {
        static void Main()
        {
            var stack = new CustomStack<int>();

            var studentStack = new CustomStack<Student>();

            studentStack.Push(new Student("Pesho", 12));
            studentStack.Push(new Student("Gosho", 22));
            studentStack.Push(new Student("Minka", 23));
            studentStack.Push(new Student("Stamat", 45));
            studentStack.Push(new Student("Kiril", 33));

            Console.WriteLine(studentStack.Min().Name);

            stack.Push(4);
            stack.Push(3);
            stack.Push(44);
            stack.Push(31);
            stack.Push(12);
            stack.Push(8);

            stack.Pop();
            stack.Pop();

            Console.WriteLine(stack);
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.IsEmpty);
            Console.WriteLine(stack.Contains(4));
            Console.WriteLine(stack.Contains(111));

            Console.WriteLine(stack.Min());

            stack.Clear();

            Console.WriteLine(stack);
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.IsEmpty);
        }
    }
}
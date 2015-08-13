namespace _14.DefiningClassesExcercise
{
    class DefiningClassesExcercise
    {
        static void Main()
        {
            Cat mimi = new Cat("Mimi", 3);
            Cat pepi = new Cat("Pepi", 2);

            pepi.Miau();
            mimi.Miau();
        }
    }
}
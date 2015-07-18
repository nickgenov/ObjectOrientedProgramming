namespace _14.DefiningClassesExcercise
{
    public class Cat
    {
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Cat(string name)
            : this(name, 1)
        {

        }
        public Cat(int age)
            : this(null, age)
        {

        }
        public Cat()
        {

        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void Miau()
        {
            System.Console.WriteLine("{0}, age: {1} said: Miauuu!", this.Name ?? "[unnamed cat]", this.Age);
        }
    }
}
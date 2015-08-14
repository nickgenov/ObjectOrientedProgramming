namespace _02.StaticExample
{
    class Person
    {
        private static int instanceCounter = 0;
        public static int InstanceCounter
        {
            get { return Person.instanceCounter; }
        }
        public string Name { get; set; }

        public Person(string name = null)
        {
            Person.instanceCounter++;
            this.Name = name;
        }
    }
}
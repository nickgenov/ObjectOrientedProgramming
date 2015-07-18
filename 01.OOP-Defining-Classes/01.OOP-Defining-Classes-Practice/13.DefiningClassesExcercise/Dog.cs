using System;

namespace _13.DefiningClassesExcercise
{

    public class Dog
    {
        private string name;
        private string breed;
        public Dog()
            : this(null, null)
        {

        }
        public Dog(string name)
            : this(name, null)
        {

        }
        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentOutOfRangeException("Name cannot be empty!");
                }
                this.name = value;
            }
        }
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public void Bark()
        {
            System.Console.WriteLine("{0} ({1}) said: Bauuuuu!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.Name != null ? this.Name : "[unnamed dog]", this.Breed != null ? this.Breed : "[unknown breed]");
        }
    }
}
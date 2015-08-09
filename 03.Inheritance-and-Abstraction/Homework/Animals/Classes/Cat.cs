using Animals.Enums;

namespace Animals.Classes
{
    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender) : base(name, age, gender)
        {
        }
    }
}
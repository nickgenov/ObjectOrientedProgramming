namespace EnumsCoffeeSize
{
    public class Coffee
    {
        public Coffee(CoffeeSize size)
        {
            this.Size = size;
        }

        public CoffeeSize Size { get; private set; }

        public override string ToString()
        {
            string output = string.Format("The {0} coffee is {1} ml.", this.Size, (int) this.Size);

            return output;
        }
    }
}
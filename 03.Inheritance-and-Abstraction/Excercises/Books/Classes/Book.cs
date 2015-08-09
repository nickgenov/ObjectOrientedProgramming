using System;
using System.Text;

namespace Books.Classes
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            protected set
            {
                if (value != null)
                {
                    this.title = value;
                }
                else
                {
                    throw new ArgumentNullException("Book title cannot be null!");
                }
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            protected set
            {
                if (value != null)
                {
                    this.author = value;
                }
                else
                {
                    throw new ArgumentNullException("Book author cannot be null!");
                }
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Book price cannot be a negative number!");
                }
            }
        }

        public override string ToString()
        {
            string output = string.Format("-Type: {0}\n-Title: {1}\n-Author: {2}\n-Price: {3:F2}\n", this.GetType().Name, this.Title, this.Author, this.Price);

            StringBuilder anotherWay = new StringBuilder();
            anotherWay.AppendFormat("-Type: {0}{1}-Title: {2}{3}-Author: {4}{5}-Price: {6:F2}{7}", this.GetType().Name,
                Environment.NewLine, this.Title, Environment.NewLine, this.Author, Environment.NewLine, this.Price,
                Environment.NewLine);

            return anotherWay.ToString();

            //return output;
        }
    }
}
using System.Linq;

namespace GenericList
{
    public struct GenericList<T>
    {
        private const int DefaultCapacity = 16;
        private T[] elements;
        private int currentIndex;

        public GenericList(int capacity = DefaultCapacity)
            :this()
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        public void Add(T element)
        {
            if (this.currentIndex == this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.currentIndex] = element;
            this.currentIndex++;
        }

        public void RemoveAtIndex(int index)
        {
            //TODO
        }

        public void InsertAtIndex(int index)
        {
            //TODO
        }

        public T this[int index]
        {
            //TODO data validation and exceptions
            get
            {
                return this.elements[index];
            }
            set
            {
                this.elements[index] = value;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                this.elements[i] = default(T);
            }

            currentIndex = 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string output = string.Join(", ", this.elements.Take(this.currentIndex - 1));

            return output;
        }

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }
    }
}
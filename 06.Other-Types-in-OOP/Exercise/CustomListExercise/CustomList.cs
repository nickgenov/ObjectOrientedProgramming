using System;
using System.Text;

namespace CustomListExercise
{
    public class CustomList<T>
        where T: IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] elements;
        private int currentIndex;

        public CustomList(int initialCapacity = DefaultCapacity)
        {
            this.elements = new T[initialCapacity];
            this.currentIndex = 0;
        }

        public void Add(T element)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.currentIndex] = element;
            currentIndex++;
        }

        public void Remove(T element)
        {
            int index = IndexOf(element);

            if (index == -1)
            {
                throw new InvalidOperationException("Element not found.");
            }

            if (index >= 0)
            {
                this.ShiftElementsLeft(index);
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.currentIndex || index < 0)
                {
                    throw new IndexOutOfRangeException("Index is outside of the boundaries of the custom list.");
                }
                return this.elements[index];
            }
            set
            {
                if (index >= this.currentIndex || index < 0)
                {
                    throw new IndexOutOfRangeException("Index is outside of the boundaries of the custom list.");
                }
                this.elements[index] = value;
            }
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

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Custom list is empty.");
            }

            T min = elements[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.CompareTo(min) == -1)
                {
                    min = currentElement;
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Custom list is empty.");
            }

            T max = elements[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.CompareTo(max) == 1)
                {
                    max = currentElement;
                }
            }

            return max;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.currentIndex; i++)
            {
                builder.Append(this.elements[i]);
                builder.Append(" ");
            }

            string result = builder.ToString();
            return result;
        }

        private void ShiftElementsLeft(int pos)
        {
            for (int i = pos; i < this.currentIndex - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];

                if (i == this.currentIndex - 2)
                {
                    this.elements[i + 1] = default(T);
                }
            }

            currentIndex--;
        }

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }
    }
}
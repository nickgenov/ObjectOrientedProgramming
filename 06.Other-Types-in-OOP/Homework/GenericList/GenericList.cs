using System;
using System.Linq;

namespace GenericList
{
    public class GenericList<T>
        where T: IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] elements;
        private int currentIndex;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.currentIndex = 0;
        }

        public void Add(T element)
        {
            if (this.currentIndex >= this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.currentIndex] = element;
            this.currentIndex++;
        }

        public void Push(T element)
        {
            this.Add(element);
        }

        public T Pop()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Generic list is empty.");
            }

            T lastElement = this.elements[this.currentIndex - 1];
            this.elements[this.currentIndex - 1] = default(T);
            this.currentIndex--;

            return lastElement;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("Index is outside of the generic list.");
                }

                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.currentIndex)
                {
                    throw new IndexOutOfRangeException("Index is outside of the generic list.");
                }

                this.elements[index] = value;
            }
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("Index is outside of the generic list.");
            }

            this.ShiftElementsLeft(index);
        }

        public void InsertAtIndex(int index, T element)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException("Index is outside of the generic list.");
            }

            this.ShiftElementsRight(index, element);
            this.elements[index] = element;
        }

        public T Min()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Generic list is empty.");
            }

            T min = this.elements[0];
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
                throw new InvalidOperationException("Generic list is empty.");
            }

            T max = this.elements[0];
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

        public void Clear()
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                this.elements[i] = default(T);
            }

            this.currentIndex = 0;
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
            string output = string.Join(", ", this.elements.Take(this.currentIndex));
            output = string.Format("[{0}]", output);

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

        private void ShiftElementsLeft(int index)
        {
            for (int i = index; i < this.currentIndex; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.currentIndex] = default(T);
            this.currentIndex--;
        }

        private void ShiftElementsRight(int index, T element)
        {
            for (int i = this.currentIndex; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.currentIndex++;
        }
    }
}
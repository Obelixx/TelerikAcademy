namespace GenericList
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable<T>
    {
        private const int defaultCapacity = 4;
        private const int defaultCount = 0;

        private int capacity = defaultCapacity;
        private int count = defaultCount;
        private T[] gList;
        private int index = 0;


        private int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value < 0 || value >= count)
                {
                    throw new ArgumentOutOfRangeException("Index must fit in the list length");
                }
                this.index = value;
            }
        }

        public int LastIndex { get { return (count - 1); } }

        public GenericList()
        {
            gList = new T[capacity];
        }

        public GenericList(int capacity)
        {
            this.capacity = capacity;
            this.gList = new T[this.capacity];
        }

        public void Add(T element)
        {
            if (this.count == this.capacity)
            {
                this.capacity = this.capacity * 2;
                var newGList = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    newGList[i] = gList[i];
                }
                gList = newGList;
            }
            gList[count++] = element;
        }

        public T this[int index]
        {
            get
            {
                this.Index = index;
                return (this.gList[Index]);
            }
            set
            {
                this.Index = index;
                this.gList[Index] = value;
            }
        }

        public void Remove(int index)
        {
            this.Index = index;
            if (Index < LastIndex)
            {
                for (int i = Index + 1; i <= LastIndex; i++)
                {
                    gList[i - 1] = gList[i];
                }
            }
            count--;
        }

        public void InsertAt(T element, int index)
        {
            this.Index = index;
            Add(element);
            if (Index < LastIndex)
            {
                for (int i = LastIndex; i > Index; i--)
                {
                    gList[i] = gList[i - 1];
                }
            }
            gList[Index] = element;
        }

        public void Clean()
        {
            this.count = defaultCount;
            this.capacity = defaultCapacity;
            this.gList = new T[defaultCapacity];
        }

        //
        // Summary:
        //     Returns the index of the element.
        //
        // Parameters:
        //   element:
        //     Element to search.
        //   Index
        //     After witch index to search.
        //
        // Returns:
        //     The index of the first found element or (-1) of not found.
        public int Find(T element, int index = 0)
        {
            this.Index = index;
            for (int i = Index; i < LastIndex; i++)
            {
                if (gList[i].Equals(element))
                {
                    return (i);
                }
            }
            return (-1);
        }

        public T Min()
        {
            if (count != 0)
            {
                T min = gList[0];
                for (int i = 1; i <= LastIndex; i++)
                {
                    if (min.CompareTo(gList[i]) > 0)
                    {
                        min = gList[i];
                    }
                }
                return min;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cant get Min value in empty GenericList!");
            }
        }

        public T Max()
        {
            if (count != 0)
            {
                T max = gList[0];
                for (int i = 1; i <= LastIndex; i++)
                {
                    if (max.CompareTo(gList[i]) < 0)
                    {
                        max = gList[i];
                    }
                }
                return max;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cant get Max value in empty GenericList!");
            }
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i <= LastIndex; i++)
            {
                sb.Append("{");
                sb.Append(gList[i].ToString());
                sb.Append("}");
            }
            return sb.ToString();
        }

    }
}

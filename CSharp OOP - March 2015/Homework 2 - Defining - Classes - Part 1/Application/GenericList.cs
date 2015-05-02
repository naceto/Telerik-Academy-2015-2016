namespace Application
{
    using System;
    using System.Collections;
    using System.Text;

    /*
        Problem 5.
        Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
        Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
        Implement methods for adding element, accessing element by index, removing element by index, 
        inserting element at given position, clearing the list, finding element by its value and ToString().
        Check all input parameters to avoid accessing elements at invalid positions.

        Problem 6. Auto-grow
        Implement auto-grow functionality: 
        when the internal array is full, create a new array of double size and move all elements to it.

        Problem 7. Min and Max
        Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
        You may need to add a generic constraints for the type T.
     */
    public class GenericList<T> where T : IComparable
    {
        // fields
        private T[] list;
        private uint nextIndex;
        private uint capacity;

        // constructors
        public GenericList(uint size = 4)
        {
            this.list = new T[size];
            this.capacity = size;
            this.nextIndex = 0;
        }

        // properties
        public uint Count
        {
            get { return nextIndex; }
        }

        public uint Capacity
        {
            get { return capacity; }
        }

        private void Resize ()
        {
            uint newCapacity = this.capacity * 2;
            T[] newList = new T[newCapacity];

            for (int i = 0; i < this.nextIndex; i++)
            {
                newList[i] = this.list[i];
            }

            this.list = newList;
            this.capacity = newCapacity;
        }

        //methods
        public void Add(T item)
        {
            if (this.nextIndex >= this.capacity)
            {
                this.Resize();
            }

            this.list[this.nextIndex] = item;
            ++this.nextIndex;
        }

        public void RemoveAt (uint index)
        {
            if (index >= this.nextIndex)
            {
                throw new IndexOutOfRangeException();
            }

            T[] newList = new T[this.capacity];
            uint j = 0;
            for (int i = 0; i < this.capacity; i++)
            {
                if (i == index)
                {
                    continue;
                }
                newList[j++] = this.list[i];
            }
            this.list = newList;
            --this.nextIndex;
        }

        public void InsertAt (uint index, T item)
        {
            if (index >= this.nextIndex)
            {
                throw new IndexOutOfRangeException("Index must be within the bounds of the List.");
            }

            if (this.nextIndex >= this.capacity)
            {
                this.Resize();
            }

            T[] newList = new T[this.capacity];
            uint j = 0;
            for (int i = 0; i < this.nextIndex; i++)
            {
                if (i == index)
                {
                    newList[j++] = item;
                }
                newList[j++] = this.list[i];
            }
            this.list = newList;
            ++this.nextIndex;
        }

        public void Clear ()
        {
            this.nextIndex = 0;
        }

        // finding element by its value
        public int Contains (T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.list[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Count == 0)
            {
                sb.AppendFormat("Empty List");
            }
            else
            {
                for (int i = 0; i < this.Count; i++)
                {
                    
                    sb.Append(this.list[i]);
                    if (i != this.Count - 1)
                    {
                        sb.Append(", ");
                    }
                }
            }
            return sb.ToString();
        }

        public uint Max ()
        {
            if (this.nextIndex == 0)
            {
                throw new Exception("The list is empty");
            }
            uint bestIndex = 0;
            T best = this.list[0];
            
            for (uint i = 1; i < this.Count; i++)
            {
                if (this.list[i].CompareTo (best) > 0)
                {
                    best = this.list[i];
                    bestIndex = i;
                }
            }

            return bestIndex;
        }


        public uint Min()
        {
            if (this.nextIndex == 0)
            {
                throw new Exception("The list is empty");
            }

            uint bestIndex = 0;
            T best = this.list[0];

            for (uint i = 1; i < this.Count; i++)
            {
                if (this.list[i].CompareTo(best) < 0)
                {
                    best = this.list[i];
                    bestIndex = i;
                }
            }

            return bestIndex;
        }

        // indexer
        public T this [uint index]
        {
            get
            {
                if (index >= this.capacity)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.list[index];
            }
        }
    }
}

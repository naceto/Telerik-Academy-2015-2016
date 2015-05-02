
namespace Problem_05_64_Bit_array.Classes
{
    using System.Collections.Generic;
    using System;

    public class BitArray64Enumerator : IEnumerator<ulong>
    {
        private BitArray64 array;
        private int index;

        public BitArray64Enumerator (BitArray64 array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            this.array = array;
            this.index = -1;
        }

        public ulong Current
        {
            get { return this.array[this.index]; }
        }

        public void Dispose()
        {}

        object System.Collections.IEnumerator.Current
        {
            get { return this.Current; }
        }

        public bool MoveNext()
        {
            this.index++;
            if (this.index > 63)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}

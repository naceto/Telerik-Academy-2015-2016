namespace Problem_05_64_Bit_array.Classes
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    // Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
    public class BitArray64 : IEnumerable<ulong>
    {
        private ulong array;

        public BitArray64 (ulong number)
        {
            this.array = number;
        }

        public ulong this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentException("index must be int the limits [0, 63]");
                }

                ulong mask = 1;
                mask <<= index;
                return (this.array & mask) >> index;
            }

            set
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentException("index must be int the limits [0, 63]");
                }

                if (value != 1 && value != 0)
                {
                    throw new ArgumentException("value must be either 1 or 0");
                }

                ulong mask = 1;
                mask <<= index;
                if (value == 0) //unset
                {
                    this.array &= ~mask;
                }
                else // set
                {
                    this.array |= mask;
                }
            }
        }

        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            var otherAsArray = other as BitArray64;
            if (otherAsArray == null)
            {
                return false;
            }
            
            for (int i = 0; i < 63; i++)
            {
                if (this[i] != otherAsArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.array.GetHashCode();
        }

        public static bool operator ==(BitArray64 lhs, BitArray64 rhs)
        {
            return BitArray64.Equals(lhs, rhs);
        }

        public static bool operator !=(BitArray64 lhs, BitArray64 rhs)
        {
            return !BitArray64.Equals(lhs, rhs);
        }


        public IEnumerator<ulong> GetEnumerator()
        {
            return new BitArray64Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

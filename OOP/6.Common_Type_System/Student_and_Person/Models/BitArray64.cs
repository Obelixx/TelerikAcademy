namespace Student_and_Person.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class BitArray64 : IEnumerable<int>
    {
        private const int IndexIntervalStart = 0;
        private const int IndexIntervalEnd = 63;
        private const int BoolIntervalStart = 0;
        private const int BoolIntervalEnd = 1;


        private ulong store;

        public ulong Store
        {
            get { return store; }
            private set { store = value; }
        }

        public BitArray64(ulong number)
        {
            this.Store = number;
        }


        private void CheckIndex(int index, int intervalStart, int intervalEnd)
        {
            if (index < intervalStart || index > intervalEnd)
            {
                throw new ArgumentException("Index must be between " + intervalStart + " and " + intervalEnd + "!");
            }
        }

        public int this[int index]
        {
            get
            {
                CheckIndex(index, IndexIntervalStart, IndexIntervalEnd);
                return (int)((this.Store >> index) & 1ul);
            }
            set
            {
                CheckIndex(index, IndexIntervalStart, IndexIntervalEnd);
                CheckIndex(value, BoolIntervalStart, BoolIntervalEnd);
                if (value == 1)
                    this.Store = (1ul << index) | this.Store;
                else
                    this.Store = (1ul << index) & this.Store;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 63; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Equals(BitArray64 bitArr)
        {
            return this.Store.Equals(bitArr.Store);
        }

        public override bool Equals(object obj)
        {
            var bitArr = obj as BitArray64;
            if (bitArr == null) throw new ArgumentException("Object type is not BitArray64!");
            return this.Equals(bitArr);
        }

        public override int GetHashCode()
        {
            return this.Store.GetHashCode();
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return a.Store == b.Store;
        }
        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return a.Store != b.Store;
        }
    }
}

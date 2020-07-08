using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS23
{
    public class Counter
    {
        private int _count = 0;

        public int Count { get => _count; set => _count = value; }
        public Counter(int count)
        {
            Count = count;
        }

        public void Call()
        {
            Count++;
        }

        public void SetCount(int value)
        {
            if (value < 100)
            {
                Count = 0;
                return;
            }

            Count = value;
        }

        public int GetCount()
        {
            return Count;
        }
    }
}

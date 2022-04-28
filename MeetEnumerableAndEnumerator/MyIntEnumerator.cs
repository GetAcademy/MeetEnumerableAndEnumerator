using System.Collections;

namespace MeetEnumerableAndEnumerator
{
    internal class MyIntEnumerator : IEnumerator<int>
    {
        public int Current { get; private set; } = 50;

        public bool MoveNext()
        {
            Console.WriteLine("MoveNext");
            Current *= 2;
            return Current < 10000;
        }

        public void Reset()
        {
            Console.WriteLine("Reset");
            Current = 50;
        }

        object IEnumerator.Current => Current;
        public void Dispose()
        {
        }
    }
}

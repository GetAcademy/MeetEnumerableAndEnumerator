using System.Collections;

namespace MeetEnumerableAndEnumerator
{
    internal class MyIntArrayEnumerator
    : IEnumerator<int>
    {
        private int _index = -1;
        private readonly int[] _numbers = { 100, 200, 400, 800 };

        public bool MoveNext()
        {
            Console.WriteLine("MoveNext");
            _index++;
            return _index < _numbers.Length;
        }

        public void Reset()
        {
            Console.WriteLine("Reset");
            _index = -1;
        }

        public int Current
        {
            get
            {
                Console.WriteLine("Leser Current");
                return _numbers[_index];
            }
        }

        object IEnumerator.Current => Current;
        public void Dispose()
        {
        }
    }
}

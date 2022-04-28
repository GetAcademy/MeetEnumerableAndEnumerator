using System.Collections;

namespace MeetEnumerableAndEnumerator
{
    internal class MyIntEnumerable
        : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            Console.WriteLine("GetEnumerator");
            return new MyIntEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Console.WriteLine("IEnumerable.GetEnumerator");
            return GetEnumerator();
        }
    }
}

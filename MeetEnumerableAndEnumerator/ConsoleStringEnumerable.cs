using System.Collections;

namespace MeetEnumerableAndEnumerator
{
    internal class ConsoleStringEnumerable : IEnumerable<string>

    {
        public IEnumerator<string> GetEnumerator()
        {
            return new ConsoleStringEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

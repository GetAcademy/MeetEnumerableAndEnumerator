using System.Collections;

namespace MeetEnumerableAndEnumerator
{
    internal class ConsoleStringEnumerator : IEnumerator<string>
    {

        public bool MoveNext()
        {
            Console.Write("Vil du fortsette (j/n)?");
            var answer = Console.ReadLine();
            var letter = answer[0];
            return letter == 'j';
        }

        public void Reset()
        {
        }

        public string Current
        {
            get
            {
                Console.Write("Hva er current verdi? ");
                return Console.ReadLine();
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}

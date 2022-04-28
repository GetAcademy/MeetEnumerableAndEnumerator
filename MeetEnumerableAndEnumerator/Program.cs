/*
 * IEnumerable
 * IEnumerator
 */

//var numbers = new[] { 100, 200, 400, 800 };

using MeetEnumerableAndEnumerator;

//var numbers = new MyIntEnumerable();
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

var txts = new ConsoleStringEnumerable();
foreach (var txt in txts)
{
    Console.WriteLine(txt);
}

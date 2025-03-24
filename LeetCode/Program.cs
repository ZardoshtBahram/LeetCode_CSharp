using System.Diagnostics;

namespace LeetCode
{
    internal class Program
    {
        // Create a class for each problem you work on 
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            _3169_CountDays test = new _3169_CountDays();
            timer.Start();
            List<string> rec = new List<string>(test.CountDays(90, [[5, 7], [1, 3], [9, 10]]));

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }
    }
}

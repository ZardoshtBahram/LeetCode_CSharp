using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace LeetCode
{
    internal class Program
    {
        // Create a class for each problem you work on 
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            _2033_MinOperationToMakeUni test = new _2033_MinOperationToMakeUni();
            timer.Start();
            Console.WriteLine(test.MinOperations([[2, 4], [6, 8]], 2)); 

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }

    }

}

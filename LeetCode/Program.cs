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
            _2_addTwoNums test = new _2_addTwoNums();
            ListNode a = new ListNode(3);
            ListNode b = new ListNode(4 , a);
            ListNode c = new ListNode(2 , b);

            ListNode d = new ListNode(4);
            ListNode e = new ListNode(6 , d);
            ListNode f = new ListNode(5 , e);
            timer.Start();

            test.AddTwoNumbers(c, f);

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }

    }

}

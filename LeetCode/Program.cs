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
            _763_PartitionLabels test = new _763_PartitionLabels();
            timer.Start();

            Console.WriteLine(string.Join( "," , test.PartitionLabels("ababcbacadefegdehijhklij")));
            

            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }

    }

}

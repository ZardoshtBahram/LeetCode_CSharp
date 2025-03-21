using System.Diagnostics;

namespace LeetCode
{
    internal class Program
    {
        // Create a class for each problem you work on 
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            _2115_AllPossiableRecipes test = new _2115_AllPossiableRecipes();
            timer.Start();

            List<string> rec = new List<string>(test.FindAllRecipes(["bread"], [["yeast", "flour"]], ["yeast", "flour", "corn"]));



            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }
    }
}

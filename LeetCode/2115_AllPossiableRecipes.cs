using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _2115_AllPossiableRecipes
    {
        public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
        {
            IList<string> result = new List<string>();
            Dictionary<string , List<string>> recipesToIng = new Dictionary<string , List<string>>();
            Dictionary<string , int> visited = new Dictionary<string , int>();
            HashSet<string> avalableSupplies = new HashSet<string>(supplies);

            for (int i = 0; i < recipes.Length; i++)
                recipesToIng.Add(recipes[i], new List<string>(ingredients[i]));


            bool canMake (string recipe) 
            {
                if (visited.ContainsKey(recipe)) 
                    return visited[recipe] == 1;

                if (avalableSupplies.Contains(recipe)) 
                    return true; 

                if (!recipesToIng.ContainsKey(recipe))
                    return false;

                visited[recipe] = 0;

                foreach (string ing in recipesToIng[recipe]) 
                {
                    if (!canMake(ing)) 
                    {
                        visited[recipe] = -1;
                        return false;
                    }
                }

                visited[recipe] = 1;
                result.Add(recipe);
                return true;

            }

            foreach (string rec in recipes) 
                canMake (rec);

            return result;
            
        }
        
    }

}

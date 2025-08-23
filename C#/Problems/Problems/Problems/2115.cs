using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2115 : IProblem
    {
        public bool Test()
        {
            var recipes = new[] { "bread", "sandwich", "burger" };
            var ingredients = new List<IList<string>> {new List<string> {"yeast", "flour"}, new List<string> {"bread", "meat"}, new List<string> {"sandwich", "meat", "bread"}};
            var supplies = new[] { "yeast", "flour", "meat" };

            var expected = new List<string> { "bread", "sandwich", "burger" };

            var result = FindAllRecipes(recipes, ingredients, supplies);

            Console.WriteLine(string.Join(", ", result));

            return result.SequenceEqual(expected);
        }

        public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
        {
            var suppliesSet = new HashSet<string>(supplies);
            var addedRecipesSet = new HashSet<string>();
            var added = 1;
            while (added > 0)
            {
                added = 0;
                for (int i = 0; i < recipes.Length; ++i)
                {
                    if (addedRecipesSet.Contains(recipes[i]))
                        continue;
                    var crafted = true;
                    foreach (var ingredient in ingredients[i])
                    {
                        if (!suppliesSet.Contains(ingredient))
                        {
                            crafted = false;
                            break;
                        }
                    }

                    if (crafted)
                    {
                        suppliesSet.Add(recipes[i]);
                        addedRecipesSet.Add(recipes[i]);
                        added++;
                    }
                }
            }

            return addedRecipesSet.ToList();
        }
    }
}

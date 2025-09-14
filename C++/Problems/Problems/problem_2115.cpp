#include "problem_2115.h"

#include <unordered_set>

bool problem_2115::test() {
    std::vector<std::string> recipes { "bread", "sandwich", "burger" };
    std::vector<std::vector<std::string>> ingredients { {"yeast", "flour"},  {"bread", "meat"},  {"sandwich", "meat", "bread"}};
    std::vector<std::string> supplies  { "yeast", "flour", "meat" };

    std::vector<std::string> expected  { "burger", "sandwich", "bread" };

    auto result = findAllRecipes(recipes, ingredients, supplies);

    print1DVector(result);

    return result == expected;
}

std::vector<std::string> problem_2115::findAllRecipes(std::vector<std::string> &recipes,
    std::vector<std::vector<std::string>> &ingredients, std::vector<std::string> &supplies) {
    std::unordered_set suppliesSet(supplies.begin(), supplies.end());
    std::unordered_set<std::string> addedRecipesSet;
    int added = 1;
    while (added > 0)
    {
        added = 0;
        for (int i = 0; i < recipes.size(); ++i)
        {
            if (addedRecipesSet.contains(recipes[i]))
                continue;
            auto crafted = true;
            for (const auto& ingredient : ingredients[i])
            {
                if (!suppliesSet.contains(ingredient))
                {
                    crafted = false;
                    break;
                }
            }

            if (crafted)
            {
                suppliesSet.insert(recipes[i]);
                addedRecipesSet.insert(recipes[i]);
                added++;
            }
        }
    }

    return std::vector(addedRecipesSet.begin(), addedRecipesSet.end());
}

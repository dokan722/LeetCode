import sys
from typing import List, Dict

from .problem import Problem


class Problem2115(Problem):
    def test(self) -> bool:
        recipes = ["bread", "sandwich", "burger"]
        ingredients = [["yeast", "flour"], ["bread", "meat"], ["sandwich", "meat", "bread"]]
        supplies = ["yeast", "flour", "meat"]

        expected = ["bread", "burger", "sandwich"]

        result = self.findAllRecipes(recipes, ingredients, supplies)
        result.sort()

        print(','.join(result))

        return result == expected

    def findAllRecipes(self, recipes: List[str], ingredients: List[List[str]], supplies: List[str]) -> List[str]:
        suppliesSet = set(supplies)
        addedRecipesSet = set()
        added = 1
        while added > 0:
            added = 0
            for i in range(len(recipes)):
                if recipes[i] in addedRecipesSet:
                    continue
                crafted = True
                for ingredient in ingredients[i]:
                    if ingredient not in suppliesSet:
                        crafted = False
                        break
                if crafted:
                    suppliesSet.add(recipes[i])
                    addedRecipesSet.add(recipes[i])
                    added += 1

        return list(addedRecipesSet)
import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1773(Problem):
    def test(self) -> bool:
        items = [["phone", "blue", "pixel"], ["computer", "silver", "lenovo"], ["phone", "gold", "iphone"]]
        ruleKey = "color"
        ruleValue = "silver"

        expected = 1

        result = self.countMatches(items, ruleKey, ruleValue)

        print(result)

        return result == expected

    def countMatches(self, items: List[List[str]], ruleKey: str, ruleValue: str) -> int:
        result = 0
        rule = 0
        if ruleKey == "color":
            rule = 1
        elif ruleKey == "name":
            rule = 2

        for item in items:
            if item[rule] == ruleValue:
                result += 1
        return result
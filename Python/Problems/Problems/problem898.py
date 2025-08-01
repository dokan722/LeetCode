import math
from typing import List, Dict

from .problem import Problem


class Problem898(Problem):
    def test(self) -> bool:
        arr = [1, 2, 4]

        expected = 6

        result = self.subarrayBitwiseORs(arr)

        print(result)

        return result == expected

    def subarrayBitwiseORs(self, arr: List[int]) -> int:
        result = set()
        partial = {0}
        for num in arr:
            tmp = set()
            for prev in partial:
                tmp.add(num | prev)
            tmp.add(num)
            for value in tmp:
                result.add(value)
            partial = tmp

        return len(result)
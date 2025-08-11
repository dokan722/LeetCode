from typing import List, Dict

from .problem import Problem


punishmentNumbers = [
    1,
    9,
    10,
    36,
    45,
    55,
    82,
    91,
    99,
    100,
    235,
    297,
    369,
    370,
    379,
    414,
    657,
    675,
    703,
    756,
    792,
    909,
    918,
    945,
    964,
    990,
    991,
    999,
    1000,
    2137
]

class Problem2698(Problem):
    def test(self) -> bool:
        n = 10

        expected = 182

        result = self.punishmentNumber(n)

        print(result)

        return result == expected


    def punishmentNumber(self, n: int) -> int:
        result = 0
        i = 0
        while punishmentNumbers[i] <= n:
            result += punishmentNumbers[i] * punishmentNumbers[i]
            i += 1

        return result
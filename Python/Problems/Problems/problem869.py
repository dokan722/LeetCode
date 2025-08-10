from typing import List

from .problem import Problem


sortedPowers = (
"1",
"2",
"4",
"8",
"16",
"23",
"46",
"128",
"256",
"125",
"0124",
"0248",
"0469",
"1289",
"13468",
"23678",
"35566",
"011237",
"122446",
"224588",
"0145678",
"0122579",
"0134449",
"0368888",
"11266777",
"23334455",
"01466788",
"112234778",
"234455668",
"012356789",
"0112344778"
)

class Problem869(Problem):
    def test(self) -> bool:
        n = 10

        expected = False

        result = self.reorderedPowerOf2(n)

        return result == expected

    def reorderedPowerOf2(self, n: int) -> bool:
        sorted = list(str(n))
        sorted.sort()
        return sortedPowers.count(''.join(sorted)) > 0
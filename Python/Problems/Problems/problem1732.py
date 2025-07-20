from typing import List

from .problem import Problem


class Problem1732(Problem):
    def test(self) -> bool:
        gain = [-5, 1, 5, 0, -7]

        expected = 1

        result = self.largestAltitude(gain)

        print(result)

        return result == expected

    def largestAltitude(self, gain: List[int]) -> int:
        att = 0
        maxAtt = 0
        for i in gain:
            att += i
            if att > maxAtt:
                maxAtt = att

        return maxAtt
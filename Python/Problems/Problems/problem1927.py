from typing import List

from .problem import Problem


class Problem1927(Problem):
    def test(self) -> bool:
        num = "?3295???"

        expected = False

        result = self.sumGame(num)

        return result == expected

    def sumGame(self, num: str) -> bool:
        n = len(num)
        q1 = 0
        q2 = 0
        sum1 = 0
        sum2 = 0
        for i in range(n // 2):
            if num[i] == '?':
                q1 += 1
            else:
                sum1 += ord(num[i]) - ord('0')
        for i in range(n // 2, n):
            if num[i] == '?':
                q2 +=1
            else:
                sum2 += ord(num[i]) - ord('0')


        if (q1 + q2) % 2 == 0 and 2 * (sum1 - sum2) == (q2 - q1) * 9:
            return False

        return True
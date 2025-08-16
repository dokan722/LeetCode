from typing import List, Dict

from .problem import Problem


class Problem1323(Problem):
    def test(self) -> bool:
        num = 9669

        expected = 9969

        result = self.maximum69Number(num)

        print(result)

        return expected == result

    def maximum69Number(self, num: int) -> int:
        sNum = list(str(num))
        n = len(sNum)
        found = False
        for i in range(n):
            if sNum[i] == '6':
                found = True
                sNum[i] = '9'
                break

        return int(''.join(sNum)) if found else num
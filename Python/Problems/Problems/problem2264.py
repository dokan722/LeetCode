from typing import List, Dict

from .problem import Problem


class Problem2264(Problem):
    def test(self) -> bool:
        num = "6777133339"

        expected = "777"

        result = self.largestGoodInteger(num)

        print(result)

        return result == expected

    def largestGoodInteger(self, num: str) -> str:
        result = ""
        for i in range(2, len(num)):
            if num[i - 2] == num[i - 1] and num[i - 1] == num[i]:
                if num[i] == '9':
                    return "999"
                if not result  or ord(num[i]) > ord(result[0]):
                    result = num[i-2:i+1]

        return result
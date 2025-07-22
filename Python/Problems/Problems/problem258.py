from .problem import Problem


class Problem258(Problem):
    def test(self) -> bool:
        num = 38

        expected = 2

        result = self.addDigits(num)

        print(result)

        return expected == result

    def addDigits(self, num: int) -> int:
        if num == 0:
            return 0
        return 1 + (num - 1) % 9
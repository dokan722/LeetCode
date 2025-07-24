from .problem import Problem


class Problem1688(Problem):
    def test(self) -> bool:
        n = 7
        expected = 6

        result = self.numberOfMatches(n)

        print(result)

        return result == expected

    def numberOfMatches(self, n: int) -> int:
        result = 0
        while n > 1:
            if n % 2 == 0:
                n //= 2
                result += n
            else:
                result += (n - 1) // 2
                n = (n - 1) // 2 + 1

        return result
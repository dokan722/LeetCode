from .problem import Problem

class Problem461(Problem):
    def test(self) -> bool:
        x = 1
        y = 4

        expected = 2

        result = self.hammingDistance(x, y)

        print(result)

        return result == expected

    def hammingDistance(self, x: int, y: int) -> int:
        return bin(x ^ y).count('1')
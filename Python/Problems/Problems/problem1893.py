from .problem import Problem

class Problem1893(Problem):
    def test(self):
        ranges = [[1, 2], [3, 4], [5, 6]]

        left = 2
        right = 5
        expected = True

        result = self.isCovered(ranges, left, right)

        print(result)

        return result == expected

    def isCovered(self, ranges, left, right):
        covered = [False for _ in range(50)]
        for ran in ranges:
            for i in range(ran[0] - 1, ran[1]):
                covered[i] = True
        for i in range(left - 1, right):
            if not covered[i]:
                return False
        return True
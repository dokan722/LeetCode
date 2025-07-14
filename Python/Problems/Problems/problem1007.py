from .problem import Problem

class Problem1007(Problem):
    def test(self) -> bool:
        tops = [2, 1, 2, 4, 2, 2]
        bottoms = [5, 2, 6, 2, 3, 2]

        expected = 2

        result = self.minDominoRotations(tops, bottoms)

        print(result)

        return expected == result

    def minDominoRotations(self, tops: list[int], bottoms: list[int]) -> int:
        n = len(tops)
        possDomi = 6
        upperNums = [0] * possDomi
        lowerNums = [0] * possDomi
        sameNumber = -1
        same = 0
        for i in range(n):
            if tops[i] != bottoms[i]:
                upperNums[tops[i] - 1] += 1
                lowerNums[bottoms[i] - 1] += 1
            else:
                if sameNumber != -1 and sameNumber != tops[i]:
                    return -1
                sameNumber = tops[i]
                same +=1

        if sameNumber != -1:
            if upperNums[sameNumber - 1] + lowerNums[sameNumber - 1] == n - same:
                return min(upperNums[sameNumber - 1], lowerNums[sameNumber - 1])
            return -1

        for i in range(possDomi):
            if upperNums[i] + lowerNums[i] == n:
                return min(upperNums[i], lowerNums[i])

        return -1
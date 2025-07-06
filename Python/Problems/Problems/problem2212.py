import sys

from .problem import Problem


class Problem2212(Problem):
    def test(self):
        numArrows = 9
        aliceArrows = [1, 1, 0, 1, 0, 0, 2, 1, 0, 1, 2, 0]

        expected = [0, 0, 0, 0, 1, 1, 0, 0, 1, 2, 3, 1]

        result = self.maximumBobPoints(numArrows, aliceArrows)

        return expected == result

    def maximumBobPoints(self, numArrows, aliceArrows):
        n = len(aliceArrows)
        reqArrows = [i for i in range(12)]
        for i in range(n):
            reqArrows[i] = aliceArrows[i] + 1
        bestResult = -sys.maxsize
        bestArrows = []

        for i in range(1 << n):
            remArrows = numArrows
            currPoints = 0
            currArrows = [0 for _ in range(12)]
            values = self.transformToBitArray(i)
            for j in range(n):
                if values[j] == 1:
                    currPoints += j
                    remArrows -= reqArrows[j];
                    currArrows[j] = reqArrows[j];

            if currPoints > bestResult and remArrows >= 0:
                currArrows[n - 1] += remArrows
                bestResult = currPoints
                bestArrows = currArrows

        return bestArrows

    def transformToBitArray(self, num):
        return [(num >> i) & 1 for i in reversed(range(12))]
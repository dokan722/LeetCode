from typing import List

from .problem import Problem


class Problem904(Problem):
    def test(self) -> bool:
        fruits = [1, 0, 1, 4, 1, 4, 1, 2, 3]

        expected = 5

        result = self.totalFruit(fruits)

        print(result)

        return expected == result

    def totalFruit(self, fruits: List[int]) -> int:
        n = len(fruits)
        start = 0

        while start < n and fruits[start] == fruits[0]:
            start += 1
        if start >= n:
            return n

        firstFruit = fruits[0]
        firstCount = start
        secondFruit = fruits[start]
        secondCount = 1

        lastSwap = start
        result = 0
        prev = fruits[start]

        for i in range(start + 1, n):
            if fruits[i] != firstFruit and fruits[i] != secondFruit:
                if firstCount + secondCount > result:
                    result = firstCount + secondCount
                if fruits[i - 1] == firstFruit:
                    secondFruit = fruits[i]
                    secondCount = 1
                    firstCount = i - lastSwap
                else:
                    firstFruit = fruits[i]
                    firstCount = 1
                    secondCount = i - lastSwap
            elif fruits[i] == firstFruit:
                firstCount += 1
            else:
                secondCount += 1

            if fruits[i] != prev:
                prev = fruits[i]
                lastSwap = i

        if firstCount + secondCount > result:
            result = firstCount + secondCount

        return result
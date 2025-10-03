import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem407(Problem):
    def test(self) -> bool:
        heightMap = [[1, 4, 3, 1, 3, 2], [3, 2, 1, 3, 2, 4], [2, 3, 3, 2, 3, 1]]

        expected = 4

        result = self.trapRainWater(heightMap)

        print(result)

        return expected == result

    def trapRainWater(self, heightMap: List[List[int]]) -> int:
        n = len(heightMap)
        m = len(heightMap[0])
        visited = []
        for i in range(n):
            visited.append([False] * m)
        boundry = []
        for i in range(n):
            heapq.heappush(boundry, (heightMap[i][0], i, 0))
            visited[i][0] = True
            heapq.heappush(boundry, (heightMap[i][m - 1], i, m - 1))
            visited[i][m - 1] = True
        for i in range(1, m - 1):
            heapq.heappush(boundry, (heightMap[0][i], 0, i))
            visited[0][i] = True
            heapq.heappush(boundry, (heightMap[n - 1][i], n - 1, i))
            visited[n - 1][i] = True

        result = 0
        while boundry:
            cell = heapq.heappop(boundry)
            if cell[1] > 0 and  not visited[cell[1] - 1][cell[2]]:
                newWater = max(0, cell[0] - heightMap[cell[1] - 1][cell[2]])
                result += newWater
                heapq.heappush(boundry, (heightMap[cell[1] - 1][cell[2]] + newWater, cell[1] - 1, cell[2]))
                visited[cell[1] - 1][cell[2]] = True
            if cell[1] < n - 1 and not visited[cell[1] + 1][cell[2]]:
                newWater = max(0, cell[0] - heightMap[cell[1] + 1][cell[2]])
                result += newWater
                heapq.heappush(boundry, (heightMap[cell[1] + 1][cell[2]] + newWater, cell[1] + 1, cell[2]))
                visited[cell[1] + 1][cell[2]] = True
            if cell[2] > 0 and not visited[cell[1]][cell[2] - 1]:
                newWater = max(0, cell[0] - heightMap[cell[1]][cell[2] - 1])
                result += newWater
                heapq.heappush(boundry, (heightMap[cell[1]][cell[2] - 1] + newWater, cell[1], cell[2] - 1))
                visited[cell[1]][cell[2] - 1] = True
            if cell[2] < m - 1 and not visited[cell[1]][cell[2] + 1]:
                newWater = max(0, cell[0] - heightMap[cell[1]][cell[2] + 1])
                result += newWater
                heapq.heappush(boundry, (heightMap[cell[1]][cell[2] + 1] + newWater, cell[1], cell[2] + 1))
                visited[cell[1]][cell[2] + 1] = True

        return result
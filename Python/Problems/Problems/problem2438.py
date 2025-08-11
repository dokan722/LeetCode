from typing import List

from .problem import Problem




powersOfTwo = [
    1,
    2,
    4,
    8,
    16,
    32,
    64,
    128,
    256,
    512,
    1024,
    2048,
    4096,
    8192,
    16384,
    32768,
    65536,
    131072,
    262144,
    524288,
    1048576,
    2097152,
    4194304,
    8388608,
    16777216,
    33554432,
    67108864,
    134217728,
    268435456,
    536870912,
    1073741824
]

class Problem2438(Problem):
    def test(self) -> bool:
        n = 15
        queries = [[0, 1], [2, 2], [0, 3]]

        expected = [2, 4, 64]

        result = self.productQueries(n, queries)

        return result == expected

    def productQueries(self, n: int, queries: List[List[int]]) -> List[int]:
        l = len(queries)
        result = [0] * l
        arr = self.getProblemArray(n)
        k = len(arr)
        mod = 1000000007
        proc = []
        for i in range(k):
            proc.append([0] * k)
        for i in range(k):
            proc[i][i] = arr[i]
            for j in range(i + 1, k):
                proc[i][j] = proc[i][j - 1] * arr[j] %mod
        for i in range(l):
            result[i] = proc[queries[i][0]][queries[i][1]]

        return result

    def transformToBitArray(self, num: int) -> List[int]:
        bits = [0] * 31

        for i in range(30, -1, -1):
            bits[30 - i] = (num >> i) & 1

        return bits

    def getProblemArray(self, n: int) -> List[int]:
        result = []
        bits = self.transformToBitArray(n)
        for i in range(len(bits)):
            if bits[30 - i] == 1:
                result.append(powersOfTwo[i])

        return result


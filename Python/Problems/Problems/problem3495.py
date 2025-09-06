from typing import List

from .problem import Problem


class Problem3495(Problem):
    def test(self) -> bool:
        queries = [[1, 2], [2, 4]]

        expected = 3

        result = self.minOperations(queries)

        print(result)

        return expected == result

    def minOperations(self, queries: List[List[int]]) -> int:
        result = 0

        for query in queries:
            left = query[0]
            right = query[1]
            begin = 1
            end = 1
            numOp = 0
            newOps = 0
            while left != 0:
                left //= 4
                begin *= 4
                numOp += 1
            while right != 0:
                right //= 4
                end *= 4

            if begin == end:
                result += ((query[1] - query[0] + 1) * numOp + 1) // 2
                continue
            newOps += numOp * (begin - query[0])
            while begin != end:
                numOp += 1
                next = begin * 4
                newOps += (next - begin) * numOp
                begin = next
            newOps -= (end - query[1] - 1) * numOp

            result += (newOps + 1) // 2

        return result
from .problem import Problem

class Problem440(Problem):
    def test(self):
        n = 681692778
        k = 351251360

        expected = 416126219

        result = self.findKthNumber(n, k)

        print(result)

        return expected == result

    def findKthNumber(self, n, k):
        curr = 1
        k -= 1

        while (k > 0):
            step = self.countSteps(n, curr, curr + 1)
            if step <= k:
                curr += 1
                k -= step
            else:
                curr *= 10
                k -= 1

        return curr

    def countSteps(self, n, p1, p2):
        steps = 0
        while p1 <= n:
            steps += min(n + 1, p2) - p1
            p1 *= 10
            p2 *= 10
        return steps
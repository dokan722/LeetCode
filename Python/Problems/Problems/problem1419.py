from .problem import Problem

class Problem1419(Problem):
    def test(self) -> bool:
        croakOfFrogs = "crcoakroak"

        expected = 2

        result = self.minNumberOfFrogs(croakOfFrogs)

        print(result)

        return result == expected

    def minNumberOfFrogs(self, croakOfFrogs: str) -> int:
        croak = "croak"
        ids = {'c': 0, 'r': 1, 'o': 2, 'a': 3, 'k': 4}
        counts = [0] * 5
        maxFrogs = 0
        for c in croakOfFrogs:
            counts[ids[c]] += 1
            if c != 'c' and counts[ids[c]] > counts[ids[c] - 1]:
                return -1;
            if c == 'k':
                frogsNow = counts[0] - counts[4] + 1;
                if frogsNow > maxFrogs:
                    maxFrogs = frogsNow
        expectedCount = counts[0]
        for i in range(1, 5):
            if counts[i] != expectedCount:
                return -1

        return maxFrogs
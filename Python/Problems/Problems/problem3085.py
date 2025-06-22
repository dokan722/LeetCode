import sys

from .problem import Problem

class Problem3085(Problem):
    def test(self):
        word = "itatwtiwwi"

        k = 1

        expected = 1

        result = self.minimumDeletions(word, k)

        print(result)

        return result == expected

    def minimumDeletions(self, word, k):
        counts = [0] * 26
        for c in word:
            counts[ord(c) - ord('a')] += 1

        counts.sort()

        start = 0
        while counts[start] == 0:
            start += 1

        if abs(counts[start] - counts[-1]) <= k:
            return 0;

        result = sys.maxsize
        for i in range(start, len(counts)):
            currMin = counts[i]
            count = 0
            for j in range(start, len(counts)):
                if counts[j] < currMin:
                    count += counts[j]
                elif abs(counts[j] - currMin) > k:
                    count += counts[j] - (currMin + k)
            if count < result:
                result = count

        return result
from typing import List

from .problem import Problem


class Problem3138(Problem):
    def test(self) -> bool:
        s = "aabbabab"

        expected = 4

        result = self.minAnagramLength(s)

        print(result)

        return expected == result

    def minAnagramLength(self, s: str) -> int:
        n = len(s)
        counts = self.countLetters(s)

        nonZero = []
        for i in range(26):
            if counts[i] != 0:
                nonZero.append(counts[i])
        if len(nonZero) == 1:
            return 1

        totalGcd = self.gcd(max(nonZero[0], nonZero[1]), min(nonZero[0], nonZero[1]))

        for i in range(2, len(nonZero)):
            totalGcd = self.gcd(max(nonZero[i], totalGcd), min(nonZero[i], totalGcd))

        for i in range(totalGcd, 1, -1):
            if n % totalGcd != 0:
                continue
            works = True
            for j in range(i):
                thisCount = self.countLetters(s[j * (n // i):(j + 1) * (n // i)])

                for k in range(26):
                    if counts[k] != thisCount[k] * i:
                        works = False
                        break
            if works:
                return n // i

        return n

    def countLetters(self, s : str) -> List[int]:
        counts = [0] * 26
        for c in s:
            counts[ord(c) - ord('a')] += 1

        return counts

    def gcd(self, bigger: int, lower: int) -> int:
        rest = bigger % lower
        if rest == 0:
            return lower
        return self.gcd(lower, rest)
from .problem import Problem


class Problem1717(Problem):
    def test(self) -> bool:
        s = "cdbcbbaaabab"
        x = 4
        y = 5

        expected = 19

        result = self.maximumGain(s, x, y)

        print(result)

        return expected == result

    def maximumGain(self, s: str, x: int, y: int) -> int:
        betterReward = max(x, y)
        worseReward = min(x, y)
        betterLetter = 'a' if x > y else 'b'
        worseLetter = 'b' if x > y else 'a'
        betterCount = 0
        worseCount = 0
        score = 0

        for c in s:
            if c == betterLetter:
                betterCount += 1
            elif c == worseLetter:
                if betterCount > 0:
                    betterCount -= 1
                    score += betterReward
                else:
                    worseCount += 1
            else:
                score += min(betterCount, worseCount) * worseReward
                betterCount = 0
                worseCount = 0

        score += min(betterCount, worseCount) * worseReward

        return score
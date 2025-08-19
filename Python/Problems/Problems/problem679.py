from typing import List, Dict

from .problem import Problem


class Problem679(Problem):
    def test(self) -> bool:
        cards = [1, 9, 1, 2]

        expected = True

        result = self.judgePoint24(cards)

        return expected == result

    def judgePoint24(self, cards: List[int]) -> bool:
        return self.judgePoint24Rec([float(card) for card in cards])

    def judgePoint24Rec(self, cards: List[float]) -> bool:
        n = len(cards)
        if n == 1:
            if abs(cards[0] - 24) < 1e-5:
                return True
            return False



        for i in range(n):
            a = cards[i]
            for j in range(n):
                if i == j:
                    continue
                b = cards[j]
                possibleResults = []
                remaining = []
                for k in range(n):
                    if k != i and k != j:
                        remaining.append(cards[k])
                possibleResults.append(a + b)
                possibleResults.append(a - b)
                possibleResults.append(a * b)
                if b != 0:
                    possibleResults.append(a / b)
                if a != 0:
                    possibleResults.append(b / a)
                for poss in possibleResults:
                    if self.judgePoint24Rec(remaining + [poss]):
                        return True

        return False
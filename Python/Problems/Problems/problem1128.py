from .problem import Problem

class Problem1128(Problem):
    def test(self):
        dominoes = [[1, 2], [2, 1], [3, 4], [5, 6]]
        expected = 1
        result = self.numEquivDominoPairs(dominoes)

        print(result)

        return expected == result

    def numEquivDominoPairs(self, dominoes):
        counts = [0] * 100
        result = 0
        for domino in dominoes:
            id = domino[0] * 10 + domino[1] if domino[0] > domino[1] else domino[1] * 10 + domino[0]
            result += counts[id]
            counts[id] += 1

        return result
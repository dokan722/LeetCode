from .problem import Problem

class Problem984(Problem):
    def test(self):
        a = 4
        b = 1

        expected = "aabaa"

        result = self.strWithout3a3b(a, b)

        print(result)

        return result == expected

    def strWithout3a3b(self, a, b):
        result = []

        domSymbol = 'a' if a > b else 'b'
        other = 'b' if domSymbol == 'a' else 'a'
        diff = abs(a - b)
        rest = ''
        if diff >= 2:
            diff -= 2
            rest = domSymbol * 2
        for a in range(min(a,b)):
            if diff > 0:
                result.append(domSymbol)
                diff -= 1
            result.append(domSymbol)
            result.append(other)

        result.append(rest)

        return ''.join(result)
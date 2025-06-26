from .problem import Problem

class Problem1417(Problem):
    def test(self):
        s = "a0b1c2"

        expected = "c2b1a0"

        result = self.reformat(s)

        print(result)

        return expected == result

    def reformat(self, s):
        digits = []
        chars = []
        for c in s:
            if c.isdigit():
                digits.append(c)
            else:
                chars.append(c)

        if abs(len(digits) - len(chars)) >= 2:
            return ''
        if len(digits) > len(chars):
            bigger = digits
            smaller = chars
        else:
            bigger = chars
            smaller = digits

        result = []
        while smaller:
            result.append(bigger.pop())
            result.append(smaller.pop())

        if bigger:
            result.append(bigger.pop())

        return ''.join(result)
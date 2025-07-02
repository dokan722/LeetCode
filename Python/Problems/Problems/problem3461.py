from .problem import Problem


class Problem3461(Problem):
    def test(self):
        s = "3902"

        expected = True

        result = self.hasSameDigits(s)

        return expected == result

    def hasSameDigits(self, s):
        while len(s) > 2:
            sb = []
            for i in range(1, len(s)):
                sb.append(chr(ord('0') + (ord(s[i - 1]) + ord(s[i]) - 2 * ord('0')) % 10));
            s = ''.join(sb)

        return s[0] == s[1]
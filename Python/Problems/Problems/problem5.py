from .problem import Problem

class Problem5(Problem):
    def test(self):
        s = "cbbd"
        expected = 'bb'

        result = self.longestPalindrome(s)

        print(result)

        return expected == result

    def longestPalindrome(self, s):
        longest = s[0]

        for i in range(len(s) - 1):
            odd = self.checkOdd(s, i)
            oddSub = s[i - odd + 1: i + odd]
            if len(oddSub) > len(longest):
                longest = oddSub
            even = self.checkEven(s, i)
            evenSub = s[i - even + 1: i + even + 1]
            if len(evenSub) > len(longest):
                longest = evenSub
        return longest

    def checkOdd(self, s, i):
        side = 1
        while i + side < len(s) and i - side >= 0:
            if s[i + side] != s[i - side]:
                return side
            side += 1

        return side

    def checkEven(self, s, i):
        if s[i] != s[i + 1]:
            return 0
        side = 1

        while i + side + 1 < len(s) and i - side >= 0:
            if s[i + side + 1] != s[i - side]:
                return side
            side += 1

        return side
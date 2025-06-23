from .problem import Problem

class Problem2081(Problem):
    def test(self):
        k = 3
        n = 7

        expected = 499

        result = self.kMirror(k, n)

        print(result)

        return result == expected

    def kMirror(self, k, n):
        found = 0
        len = 1
        result = 0
        while found < n:
            if len % 2 == 0:
                half = len // 2
                start = pow(10, half - 1)
                end = start * 10
                for i in range(start, end):
                    numS = str(i) + str(i)[::-1]
                    num = int(numS)
                    if self.isPalindrome(numS) and self.isPalindrome(self.convertToBaseReversed(num, k)):
                        found += 1
                        result += num
                        if found == n:
                            break
            else:
                half = (len + 1) // 2
                start = pow(10, half - 1)
                end = start * 10
                for i in range(start, end):
                    numS = str(i) + str(i)[:-1][::-1]
                    num = int(numS)
                    if self.isPalindrome(numS) and self.isPalindrome(self.convertToBaseReversed(num, k)):
                        found += 1
                        result += num
                        if found == n:
                            break
            len += 1

        return result

    def isPalindrome(self, s):
        for i in range(len(s)):
            if s[i] != s[len(s) - i - 1]:
                return False

        return True

    def convertToBaseReversed(self,  n,  b):
        result = ''
        while n > 0:
            next = n % b
            result += str(next)
            n = n // b

        return result

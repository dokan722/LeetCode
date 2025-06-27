from .problem import Problem

class Problem3120(Problem):
    def test(self):
        word = "aaAbcBC"

        expected = 3

        reslut = self.numberOfSpecialChars(word)

        return expected == reslut

    def numberOfSpecialChars(self, word):
        charDic = {}
        for i in range(26):
            charDic[i] = [False, False]

        for c in word:
            if c.isupper():
                charDic[ord(c) - ord('A')][0] = True
            else:
                charDic[ord(c) - ord('a')][1] = True

        result = 0
        for c in charDic.values():
            if c[0] and c[1]:
                result += 1

        return result
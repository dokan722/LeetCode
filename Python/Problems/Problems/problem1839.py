from .problem import Problem


class Problem1839(Problem):
    def test(self):
        word = "aeiaaioaaaaeiiiiouuuooaauuaeiu"

        expected = 13

        result = self.longestBeautifulSubstring(word)

        print(result)

        return result == expected

    def longestBeautifulSubstring(self, word):
        maxLen = 0
        nextReq = -1
        l = 0
        vowels = ['a', 'e', 'i', 'o', 'u']
        for c in word:
            if c == 'u' and nextReq == 4:
                l += 1
                if l > maxLen:
                    maxLen = l
            elif nextReq != -1 and c == vowels[nextReq]:
                l += 1
            elif nextReq < 4 and c == vowels[nextReq + 1]:
                l += 1
                nextReq += 1
                if c == 'u' and nextReq == 4:
                    if l > maxLen:
                        maxLen = l
            else:
                nextReq = -1
                l = 0
                if c == 'a':
                    nextReq += 1
                    l += 1

        return maxLen
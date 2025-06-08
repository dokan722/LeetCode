from .problem import Problem

class Problem3(Problem):
    def test(self):
        s = "alouzxilkaxkufsu"
        expected = 8

        result = self.lengthOfLongestSubstring(s)

        return expected == result


    def lengthOfLongestSubstring(self, s):
        partsDic = {}
        longest = 0
        currLen = 0
        for i in range(len(s)):
            currLen += 1
            if s[i] in partsDic:
                dist = i - partsDic[s[i]]
                if dist <= currLen:
                    currLen = dist
                if currLen > longest:
                    longest = currLen
            else:
                if currLen > longest:
                    longest = currLen
            partsDic[s[i]] = i
        if currLen > longest:
            longest = currLen

        return longest

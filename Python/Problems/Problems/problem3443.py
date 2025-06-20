from .problem import Problem

class Problem3443(Problem):
    def test(self):
        s = "NWSE"
        k = 1

        expected = 3

        result = self.maxDistance(s, k)

        print(result)

        return expected == result

    def maxDistance(self, s, k):
        ns = 0
        ss = 0
        ws = 0
        es = 0
        result = 0

        for c in s:
            if c == 'N':
                ns += 1
            elif c == 'S':
                ss += 1
            elif c == 'W':
                ws +=1
            elif c == 'E':
                es += 1
            
            maxChangeNS = min(k, min(ns, ss))
            maxChangeWE = min(k - maxChangeNS, min(es, ws))
            maxDist = (max(ns, ss) - min(ns, ss)) + (max(ws, es) - min(ws, es)) + 2 * (maxChangeWE + maxChangeNS)
            if maxDist > result:
                result = maxDist
        return result
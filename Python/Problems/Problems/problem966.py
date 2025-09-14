from utils import print1DArray, print2DArray
from typing import List

from .problem import Problem


class Problem966(Problem):
    def test(self) -> bool:
        wordlist = ["KiTe", "kite", "hare", "Hare"]
        queries = ["kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto"]

        expected = ["kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe"]

        result = self.spellchecker(wordlist, queries)

        print1DArray(result)

        return result == expected

    def spellchecker(self, wordlist: List[str], queries: List[str]) -> List[str]:
        exactMatches = set()
        caseMatches = dict()
        vowelMatches = dict()
        for word in wordlist:
            exactMatches.add(word)
            lower = word.lower()
            if lower not in caseMatches:
                caseMatches[lower] = word
            wildcard = self.wildcardVowels(word)
            if wildcard not in vowelMatches:
                vowelMatches[wildcard] = word

        n = len(queries)
        result = []
        for i in range(n):
            if queries[i] in exactMatches:
                result.append(queries[i])
                continue
            lower = queries[i].lower()
            if lower in caseMatches:
                result.append(caseMatches[lower])
                continue
            wildcard = self.wildcardVowels(queries[i])
            if wildcard in vowelMatches:
                result.append(vowelMatches[wildcard])
                continue
            result.append("")

        return result

    def wildcardVowels(self, word: str) -> str:
        result = ""
        for c in word.lower():
            if c == 'a' or c == 'e' or c == 'i' or c == 'o' or c == 'u':
                result += '_'
            else:
                result += c
        return result
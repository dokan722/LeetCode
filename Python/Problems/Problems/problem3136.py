from .problem import Problem

class Problem3136(Problem):
    def test(self) -> bool:
        word = "234Adas"
        expected = True

        result = self.isValid(word)

        return expected == result

    def isValid(self, word: str) -> bool:
        if len(word) < 3:
            return False
        vowels = ['a', 'e', 'i', 'o', 'u']
        haveVowel = False
        haveCons = False
        for c in word:
            if c.lower() in vowels:
                haveVowel = True
            elif c.isalpha():
                haveCons = True
            elif not c.isdigit():
                return False

        return haveCons and haveVowel
#include "problem_3325.h"

bool problem_3325::test() {
    std::string s = "abacb";
    int k = 2;

    int expected = 4;

    int result = numberOfSubstrings(s, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3325::numberOfSubstrings(std::string s, int k) {
    int n = s.size();
    int i = -1;
    int j = -1;
    int result = 0;
    int maxLetter = 0;
    std::vector counts(26, 0);
    while (i < n - 1)
    {
        while (i < n - 1 && counts[maxLetter] < k)
        {
            i++;
            counts[s[i] - 'a']++;
            if (counts[s[i] - 'a'] > counts[maxLetter])
                maxLetter = s[i] - 'a';
        }

        while (j < n - 1 && counts[maxLetter] >= k)
        {
            result += (n - i);
            j++;
            counts[s[j] - 'a']--;
        }
    }

    return result;
}

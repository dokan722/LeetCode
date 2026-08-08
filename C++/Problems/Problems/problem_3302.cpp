#include "problem_3302.h"

bool problem_3302::test() {
    std::string word1 = "vbcca";
    std::string word2 = "abc";

    std::vector expected  { 0, 1, 2 };

    auto result = validSequence(word1, word2);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3302::validSequence(std::string word1, std::string word2) {
    int n = word1.size();
    int m = word2.size();
    std::vector<int> suf(n);
    int c = 0;
    int j = m - 1;
    for (int i = n - 1; i >= 0; --i)
    {
        suf[i] = c;
        if (j > 0 && word1[i] == word2[j])
        {
            c++;
            j--;
        }
    }
    std::vector<int> result(m);
    j = 0;
    bool changed = false;
    for (int i = 0; i < n && j < m; ++i)
    {
        if (word2[j] == word1[i])
        {
            result[j] = i;
            j++;
        }
        else if (!changed && suf[i] >= m - j - 1)
        {
            result[j] = i;
            j++;
            changed = true;
        }
    }

    return j == m ? result : std::vector<int>();
}

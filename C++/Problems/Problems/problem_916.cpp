#include "problem_916.h"

bool problem_916::test() {
    std::vector<std::string> words1 { "amazon", "apple", "facebook", "google", "leetcode" };
    std::vector<std::string> words2 { "e", "o" };

    std::vector<std::string> expected { "facebook", "google", "leetcode" };

    auto result = wordSubsets(words1, words2);

    print1DVector(result);

    return expected == result;
}

std::vector<std::string> problem_916::wordSubsets(std::vector<std::string> &words1, std::vector<std::string> &words2) {
    int n = words1.size();
    int m = words2.size();
    std::vector counts1(n, std::vector<int>(26, 0));
    std::vector counts2(26, 0);
    for (int i = 0; i < n; ++i)
    {
        for (auto c : words1[i])
            counts1[i][c - 'a']++;
    }
    for (int i = 0; i < m; ++i)
    {
        std::vector counts(26, 0);
        for (auto c : words2[i])
            counts[c - 'a']++;
        for (int j = 0; j < 26; ++j)
            counts2[j] = std::max(counts2[j], counts[j]);
    }
    std::vector<std::string> result;
    for (int i = 0; i < n; ++i)
    {
        bool fit = true;
        for (int j = 0; j < 26; ++j)
        {
            if (counts2[j] > counts1[i][j])
            {
                fit = false;
                break;
            }
        }
        if (fit)
            result.push_back(words1[i]);
    }

    return result;
}

#include "problem_2559.h"

bool problem_2559::test() {
    std::vector<std::string> words { "aba", "bcb", "ece", "aa", "e" };
    std::vector<std::vector<int>> queries  {  { 0, 2 },  { 1, 4 },  { 1, 1 } };

    std::vector expected  { 2, 3, 0 };

    auto result = vowelStrings(words, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2559::vowelStrings(std::vector<std::string> &words, std::vector<std::vector<int>> &queries) {
    int n = words.size();
    int m = queries.size();
    std::vector cnt(n + 1, 0);
    for (int i = 1; i <= n; ++i)
    {
        cnt[i] = cnt[i - 1];
        std::string word = words[i - 1];
        char f = word[0];
        char l = word[word.size() - 1];
        if ((f == 'a' || f == 'e' || f == 'i' || f == 'o' || f == 'u') && (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u'))
            cnt[i]++;
    }

    std::vector<int> result(m);
    for (int i = 0; i < m; ++i)
    {
        result[i] = cnt[queries[i][1] + 1] - cnt[queries[i][0]];
    }

    return result;
}

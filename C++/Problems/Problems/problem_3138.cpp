#include "problem_3138.h"

bool problem_3138::test() {
    std::string s = "aabbabab";

    auto expected = 4;

    auto result = minAnagramLength(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3138::minAnagramLength(std::string s) {
    int n = s.size();
    auto counts = countLetters(s);

    std::vector<int> nonZero;
    for (int i = 0; i < 26; ++i)
    {
        if (counts[i] != 0)
            nonZero.push_back(counts[i]);
    }

    if (nonZero.size() == 1)
        return 1;

    auto totalGcd = gcd(std::max(nonZero[0], nonZero[1]), std::min(nonZero[0], nonZero[1]));

    for (int i = 2; i < nonZero.size(); ++i)
    {
        totalGcd = gcd(std::max(nonZero[i], totalGcd), std::min(nonZero[i], totalGcd));
    }

    for (int i = totalGcd; i > 1; --i)
    {
        if (n % totalGcd != 0)
            continue;
        auto works = true;
        for (int j = 0; j < i; ++j)
        {
            auto thisCount = countLetters(s.substr(j * n / i, n / i));

            for (int k = 0; k < 26; k++)
            {
                if (counts[k] != thisCount[k] * i)
                {
                    works = false;
                    break;
                }
            }
        }
        if (works)
            return n / i;
    }

    return n;
}

std::vector<int> problem_3138::countLetters(std::string s) {
    std::vector<int> counts(26);
    for (char c : s)
    {
        counts[c - 'a']++;
    }

    return counts;
}

int problem_3138::gcd(int bigger, int lower) {
    auto rest = bigger % lower;
    if (rest == 0)
        return lower;
    return gcd(lower, rest);
}

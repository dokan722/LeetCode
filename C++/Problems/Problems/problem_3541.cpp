#include "problem_3541.h"

bool problem_3541::test() {
    std::string s = "successes";

    int expected = 6;

    int result = maxFreqSum(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3541::maxFreqSum(std::string s) {
    std::vector counts(26, 0);

    for (char c : s)
    {
        counts[c - 'a']++;
    }

    int maxVow = 0;
    int maxCons = 0;
    for (int i = 0; i < 26; ++i)
    {
        char letter = i + 'a';
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            if (counts[i] > maxVow)
                maxVow = counts[i];
        }
        else
        {
            if (counts[i] > maxCons)
                maxCons = counts[i];
        }
    }

    return maxVow + maxCons;
}

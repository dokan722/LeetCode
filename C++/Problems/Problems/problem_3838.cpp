#include "problem_3838.h"

bool problem_3838::test() {
    std::vector<std::string> words { "abcd", "def", "xyz" };
    std::vector weights { 5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2 };

    std::string expected = "rij";

    auto result = mapWordWeights(words, weights);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_3838::mapWordWeights(std::vector<std::string> &words, std::vector<int> &weights) {
    std::string result = "";
    for (auto w : words)
    {
        int s = 0;
        for (auto c : w)
            s += weights[c - 'a'];
        result += (char)('z' - (s % 26));
    }
    return result;
}

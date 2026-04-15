#include "problem_2515.h"

bool problem_2515::test() {
    std::vector<std::string> words { "hello", "i", "am", "leetcode", "hello" };
    std::string target = "hello";
    int startIndex = 1;

    int expected = 1;

    auto result = closestTarget(words, target, startIndex);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2515::closestTarget(std::vector<std::string> &words, std::string target, int startIndex) {
    int n = words.size();
    int result = INT_MAX;
    for (int i = 0; i < n; ++i)
    {
        int cur = (startIndex + i) % n;
        if (words[cur] == target)
            result = std::min(result, std::min(i, n - i));
    }

    return result == INT_MAX ? -1 : result;
}

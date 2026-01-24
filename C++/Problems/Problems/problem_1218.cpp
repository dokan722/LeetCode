#include "problem_1218.h"

#include <unordered_map>

bool problem_1218::test() {
    std::vector arr { 1, 5, 7, 8, 5, 3, 4, 2, 1 };
    int difference = -2;

    int expected = 4;

    auto result = longestSubsequence(arr, difference);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1218::longestSubsequence(std::vector<int> &arr, int difference) {
    std::unordered_map<int, int> subsequences;
    int maxLength = 0;
    for (auto num : arr)
    {
        int prev = num - difference;
        if (subsequences.contains(prev))
            subsequences[num] = subsequences[prev] + 1;
        else
            subsequences[num] = 1;
        maxLength = std::max(maxLength, subsequences[num]);
    }

    return maxLength;
}

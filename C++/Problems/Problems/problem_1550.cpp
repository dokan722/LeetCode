#include "problem_1550.h"

bool problem_1550::test() {
    std::vector arr  { 2, 6, 4, 1 };

    bool expected = false;

    auto result = threeConsecutiveOdds(arr);

    return expected == result;
}

bool problem_1550::threeConsecutiveOdds(std::vector<int> &arr) {
    int n = arr.size();
    for (int i = 2; i < n; ++i)
    {
        if ((arr[i - 2] & 1) == 1 && (arr[i - 1] & 1) == 1 && (arr[i] & 1) == 1)
            return true;
    }

    return false;
}

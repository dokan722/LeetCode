#include "problem_1539.h"

bool problem_1539::test() {
    std::vector arr  { 2, 3, 4, 7, 11 };
    int k = 5;

    int expected = 9;

    auto result = findKthPositive(arr, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1539::findKthPositive(std::vector<int> &arr, int k) {
    int cur = k;
    for (auto num  : arr)
    {
        if (cur < num)
            return cur;
        cur += 1;
    }

    return cur;
}

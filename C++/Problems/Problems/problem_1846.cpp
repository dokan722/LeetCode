#include "problem_1846.h"

bool problem_1846::test() {
    std::vector arr { 2, 2, 1, 2, 1 };

    int expected = 2;

    auto result = maximumElementAfterDecrementingAndRearranging(arr);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1846::maximumElementAfterDecrementingAndRearranging(std::vector<int> &arr) {
    int n = arr.size();
    std::sort(arr.begin(), arr.end());
    int th = 1;
    for (int i = 1; i < n; ++i)
        th = std::min(th + 1, arr[i]);
    return th;
}

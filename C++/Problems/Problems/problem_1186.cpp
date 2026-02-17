#include "problem_1186.h"

bool problem_1186::test() {
    std::vector arr  { 1, -2, -2, 3 };

    int expected = 3;

    auto result = maximumSum(arr);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1186::maximumSum(std::vector<int> &arr) {
    int n = arr.size();
    int all = arr[0];
    int del = arr[0];
    int result = arr[0];
    for (int i = 1; i < n; ++i)
    {
        del = std::max(all, del + arr[i]);
        all = std::max(all + arr[i], arr[i]);
        result = std::max(result, std::max(all, del));
    }

    return result;
}

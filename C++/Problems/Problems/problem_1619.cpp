#include "problem_1619.h"

#include <algorithm>

bool problem_1619::test() {
    std::vector arr { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 };

    auto expected = 2.0;

    auto result = trimMean(arr);

    std::cout << result << std::endl;

    return result == expected;
}

double problem_1619::trimMean(std::vector<int> &arr) {
    std::ranges::sort(arr);
    int n = arr.size();
    int outliners = n / 20;

    int sum = 0;
    for (int i = outliners; i < n - outliners; i++)
    {
        sum += arr[i];
    }

    return (double)sum / (n - 2 * outliners);
}

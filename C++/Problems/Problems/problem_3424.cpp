#include "problem_3424.h"

bool problem_3424::test() {
    std::vector arr { -7, 9, 5 };
    std::vector brr { 7, -2, -5 };
    int k = 2;

    int expected = 13;

    auto result = minCost(arr, brr, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3424::minCost(std::vector<int> &arr, std::vector<int> &brr, long long k) {
    int n = arr.size();
    long sortedResult = k;
    long unsortedResult = 0;
    auto sorted = arr;
    std::sort(sorted.begin(), sorted.end());
    std::vector<int> order(n);
    for (int i = 0; i < n; i++)
        order[i] = i;
    std::sort(order.begin(), order.end(), [&](int a, int b) { return brr[a] < brr[b]; });
    for (int i = 0; i < n; ++i)
    {
        sortedResult += std::abs(sorted[i] - brr[order[i]]);
        unsortedResult += std::abs(arr[i] - brr[i]);
    }

    return std::min(sortedResult, unsortedResult);
}

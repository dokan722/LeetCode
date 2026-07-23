#include "problem_1343.h"

bool problem_1343::test() {
    std::vector arr { 2, 2, 2, 2, 5, 5, 5, 8 };
    int k = 3;
    int threshold = 4;

    int expected = 3;

    auto result = numOfSubarrays(arr, k, threshold);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1343::numOfSubarrays(std::vector<int> &arr, int k, int threshold) {
    int n = arr.size();
    int cur = 0;
    for (int i = 0; i < k; ++i)
        cur += arr[i];
    int result = cur / k >= threshold ? 1 : 0;
    for (int i = 0; i < n - k; ++i)
    {
        cur -= arr[i];
        cur += arr[i + k];
        if (cur / k >= threshold)
            result++;
    }

    return result;
}

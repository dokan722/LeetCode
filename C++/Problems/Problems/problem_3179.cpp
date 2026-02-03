#include "problem_3179.h"

bool problem_3179::test() {
    int n = 4;
    int k = 5;

    int expected = 56;

    auto result = valueAfterKSeconds(n, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3179::valueAfterKSeconds(int n, int k) {
    std::vector<int> arr(n, 1);
    int mod = 1000000007;
    for (int i = 0; i < k; ++i)
        for (int j = 1; j < n; ++j)
            arr[j] = (arr[j - 1] + arr[j]) % mod;
    return arr[n - 1];
}

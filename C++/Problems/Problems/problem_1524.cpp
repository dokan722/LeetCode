#include "problem_1524.h"

bool problem_1524::test() {
    std::vector arr { 1, 2, 3, 4, 5, 6, 7 };

    int expected = 16;

    auto result = numOfSubarrays(arr);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1524::numOfSubarrays(std::vector<int> &arr) {
    int n = arr.size();
    int mod = 1000000007;
    int even = arr[0] % 2 == 0 ? 1 : 0;
    int odd = arr[0] % 2 == 0 ? 0 : 1;
    int result = odd;

    for (int i = 1; i < n; ++i)
    {
        if (arr[i] % 2 == 0)
        {
            even += 1;
        }
        else
        {
            int tmp = odd;
            odd = even + 1;
            even = tmp;
        }
        result = (result + odd) % mod;
    }

    return result;
}

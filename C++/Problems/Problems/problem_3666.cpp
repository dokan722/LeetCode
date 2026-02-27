#include "problem_3666.h"

bool problem_3666::test() {
    std::string s = "0101";
    int k = 3;

    int expected = 2;

    auto result = minOperations(s, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3666::minOperations(std::string s, int k) {
    int n = s.size();
    int zeros = 0;
    for (auto c : s)
        if (c == '0')
            zeros++;
    if (zeros == 0)
        return 0;
    if (n == k)
        return zeros == n ? 1 : -1;
    int ones = n - zeros;
    int b = n - k;
    int result = INT_MAX;
    if ((k % 2) == (zeros % 2))
    {
        result = std::max((zeros + k - 1) / k, (ones + b - 1) / b);
        if (result % 2 == 0)
            result++;
    }
    if ((zeros % 2) == 0)
    {
        int even = std::max((zeros + k - 1) / k, (zeros + b - 1) / b);
        if (even % 2 == 1)
            even++;
        result = std::min(result, even);
    }

    return result == INT_MAX ? -1 : result;
}

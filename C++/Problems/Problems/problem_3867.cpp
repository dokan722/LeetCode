#include "problem_3867.h"

bool problem_3867::test() {
    std::vector nums { 2, 6, 4 };

    int expected = 2;

    auto result = gcdSum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3867::gcdSum(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> prefs(n);
    int mx = 0;
    for (int i = 0; i < n; ++i)
    {
        mx = std::max(mx, nums[i]);
        prefs[i] = gcd(mx, nums[i]);
    }
    std::sort(prefs.begin(), prefs.end());
    long result = 0;
    for (int i = 0; i < n / 2; ++i)
    {
        result += gcd(prefs[i], prefs[n - 1 - i]);
    }
    return result;
}

int problem_3867::gcd(int a, int b) {
    if (b > a)
        std::swap(a, b);
    while (b != 0)
    {
        a %= b;
        std::swap(a, b);
    }

    return a;
}

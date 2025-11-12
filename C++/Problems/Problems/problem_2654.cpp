#include "problem_2654.h"

bool problem_2654::test() {
    std::vector nums { 2, 6, 3, 4 };

    int expected = 4;

    auto result = minOperations(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2654::minOperations(std::vector<int> &nums) {
    int n = nums.size();
    int ones = 0;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] == 1)
            ones++;
    }

    if (ones > 0)
        return n - ones;

    int minDist = INT_MAX;
    for (int i = 0; i < n; ++i)
    {
        int curr = nums[i];
        for (int j = i + 1; j < n; ++j)
        {
            curr = gcd(curr, nums[j]);
            if (curr == 1)
            {
                minDist = std::min(j - i - 1, minDist);
                break;
            }
        }
    }

    if (minDist > n)
        return -1;

    return n + minDist;
}


int problem_2654::gcd(int a, int b) {
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}

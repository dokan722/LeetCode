#include "problem_477.h"

bool problem_477::test() {
    std::vector nums { 4, 14, 2 };

    int expected = 6;

    auto result = totalHammingDistance(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_477::totalHammingDistance(std::vector<int> &nums) {
    std::vector zeros(32, 0);
    std::vector ones(32, 0);
    int result = 0;
    for (auto num : nums)
    {
        int tmp = num;
        for (int i = 0; i < 32; ++i)
        {
            int rest = tmp % 2;
            if (rest == 0)
            {
                result += ones[i];
                zeros[i]++;
            }
            else
            {
                result += zeros[i];
                ones[i]++;
            }
            tmp >>= 1;
        }
    }
    return result;
}

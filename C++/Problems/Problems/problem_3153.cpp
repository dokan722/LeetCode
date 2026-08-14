#include "problem_3153.h"

bool problem_3153::test() {
    std::vector nums  { 13, 23, 12 };

    int expected = 4;

    auto result = sumDigitDifferences(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3153::sumDigitDifferences(std::vector<int> &nums) {
    int n = nums.size();
    int l = std::to_string(nums[0]).size();
    std::vector digs(l, std::vector(10, 0));
    long long result = 0;
    for (int i = 0; i < n; ++i)
    {
        int num = nums[i];
        for (int j = 0; j < l; ++j)
        {
            int c = num % 10;
            int diff = 0;
            for (int k = 0; k < 10; ++k)
            {
                if (k != c)
                    diff += digs[j][k];
            }
            result += diff;
            digs[j][c]++;
            num /= 10;
        }
    }

    return result;
}

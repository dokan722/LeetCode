#include "problem_1567.h"

bool problem_1567::test() {
    std::vector nums  { 1, -2, -3, 4 };

    int expected = 4;

    auto result = getMaxLen(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1567::getMaxLen(std::vector<int> &nums) {
    int n = nums.size();
    int prev = -1;
    int first = -1;
    int last = -1;
    int count = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] < 0)
        {
            count++;
            last = i;
            if (first == -1)
                first = i;
        }
        else if (nums[i] == 0)
        {
            if (count % 2 == 0)
            {
                result = std::max(result, i - prev - 1);
            }
            else
            {
                int best = std::max(i - first - 1, last - prev - 1);
                result = std::max(result, best);
            }
            count = 0;
            first = -1;
            last = -1;
            prev = i;
        }
    }
    if (count % 2 == 0)
    {
        result = std::max(result, n - prev - 1);
    }
    else
    {
        int best = std::max(n - first - 1, last - prev - 1);
        result = std::max(result, best);
    }


    return result;
}

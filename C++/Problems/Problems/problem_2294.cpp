#include "problem_2294.h"

#include <algorithm>
#include <iostream>
#include <ostream>

bool problem_2294::test() {
    std::vector nums { 3, 6, 1, 2, 5 };

    auto k = 2;

    auto expected = 2;

    auto result = partitionArray(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2294::partitionArray(std::vector<int> &nums, int k) {
    std::sort(begin(nums), end(nums));
    auto cnt = 0;
    auto prev = nums[0];
    auto result = 0;
    auto addLast = true;
    for (int i = 0; i < nums.size(); i++)
    {
        if (nums[i] != prev)
        {
            addLast = false;
            cnt += nums[i] - prev;
            prev = nums[i];
            if (cnt > k)
            {
                cnt = 0;
                result++;
                addLast = true;
            }
        }
    }

    if (cnt != 0 || addLast)
        result++;

    return result;
}

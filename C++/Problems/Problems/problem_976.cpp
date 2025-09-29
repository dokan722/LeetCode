#include "problem_976.h"

#include <algorithm>

bool problem_976::test() {
    std::vector nums { 2, 1, 2 };

    int expected = 5;

    auto result = largestPerimeter(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_976::largestPerimeter(std::vector<int> &nums) {
    int n = nums.size();
    std::sort(nums.begin(), nums.end());

    for (int i = n - 1; i >= 2; --i)
    {
        if (nums[i] < nums[i - 1] + nums[i - 2])
            return nums[i] + nums[i - 1] + nums[i - 2];
    }

    return 0;
}

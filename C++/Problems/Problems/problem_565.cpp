#include "problem_565.h"

bool problem_565::test() {
    std::vector nums { 5, 4, 0, 3, 1, 6, 2 };

    int expected = 4;

    auto result = arrayNesting(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_565::arrayNesting(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        int l = 1;
        if (nums[i] != -1)
        {
            int cur = nums[i];
            nums[i] = -1;
            while (cur != i)
            {
                l++;
                int val = nums[cur];
                nums[cur] = -1;
                cur = val;
            }
            result = std::max(result, l);
        }
    }

    return result;
}

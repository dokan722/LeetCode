#include "problem_1760.h"

bool problem_1760::test() {
    std::vector nums { 2, 4, 8, 2 };
    int maxOperations = 4;

    int expected = 2;

    auto result = minimumSize(nums, maxOperations);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1760::minimumSize(std::vector<int> &nums, int maxOperations) {
    int n = nums.size();
    int left = 1;
    int right = INT_MIN;
    for (int i = 0; i < n; ++i)
        right = std::max(nums[i], right);
    while (left < right)
    {
        int mid = (left + right) / 2;
        bool possible = true;
        int operationsLeft = maxOperations;
        for (int i = 0; i < n; ++i)
        {
            int needed = ((nums[i] + mid - 1) / mid) - 1;
            operationsLeft -= needed;
            if (operationsLeft < 0)
            {
                possible = false;
                break;
            }
        }
        if (possible)
            right = mid;
        else
            left = mid + 1;
    }

    return left;
}

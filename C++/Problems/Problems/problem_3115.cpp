#include "problem_3115.h"

bool problem_3115::test() {
    std::vector nums { 4, 2, 9, 5, 3 };

    int expected = 3;

    auto result = maximumPrimeDifference(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3115::maximumPrimeDifference(std::vector<int> &nums) {
    int n = nums.size();
    std::vector possiblePrimeDivisors { 2, 3, 5, 7 };
    int first = -1;
    int last = 0;
    for (int i = 0; i < n; ++i)
    {
        bool isPrime = true;
        for (auto prime : possiblePrimeDivisors)
        {
            if (nums[i] == 1 || (nums[i] % prime == 0 && nums[i] / prime != 1))
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            if (first == -1)
                first = i;
            last = i;
        }
    }

    return last - first;
}

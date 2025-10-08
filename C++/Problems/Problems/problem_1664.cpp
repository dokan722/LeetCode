#include "problem_1664.h"

bool problem_1664::test() {
    std::vector nums { 2, 1, 6, 4 };

    int expected = 1;

    auto result = waysToMakeFair(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1664::waysToMakeFair(std::vector<int> &nums) {
    int n = nums.size();
    int evenSum = 0;
    int oddSum = 0;
    for (int i = 0; i < n; ++i)
    {
        if (i % 2 == 0)
            evenSum += nums[i];
        else
            oddSum += nums[i];
    }

    int currEven = 0;
    int currOdd = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (i % 2 == 0)
        {

            if (currEven + (oddSum - currOdd) == currOdd + (evenSum - currEven - nums[i]))
                result++;
            currEven += nums[i];
        }
        else
        {
            if (currEven + (oddSum - currOdd - nums[i]) == currOdd + (evenSum - currEven))
                result++;
            currOdd += nums[i];
        }
    }

    return result;
}

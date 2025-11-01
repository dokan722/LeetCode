#include "problem_3289.h"

bool problem_3289::test() {
    std::vector nums { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 };

    std::vector expected { 4, 5 };

    auto result = getSneakyNumbers(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3289::getSneakyNumbers(std::vector<int> &nums) {
    int n = nums.size();
    std::vector seen(n, false);
    int first = -1;
    for (auto num : nums)
    {
        if (seen[num])
        {
            if (first != -1)
                return{ first, num };
            first = num;
        }
        else
            seen[num] = true;
    }

    return {};
}

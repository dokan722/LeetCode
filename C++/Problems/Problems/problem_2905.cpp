#include "problem_2905.h"

bool problem_2905::test() {
    std::vector nums { 5, 1, 4, 1 };
    int indexDifference = 2;
    int valueDifference = 4;

    std::vector expected { 0, 3 };

    auto result = findIndices(nums, indexDifference, valueDifference);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2905::findIndices(std::vector<int> &nums, int indexDifference, int valueDifference) {
    int n = nums.size();
    int mx = 0;
    int mn = 0;
    for (int i = indexDifference; i < n; ++i)
    {
        int id = i - indexDifference;
        if (nums[mx] < nums[id])
            mx = id;
        else if (nums[mn] > nums[id])
            mn = id;
        if (std::abs(nums[i] - nums[mx]) >= valueDifference)
            return std::vector { mx, i };
        if (std::abs(nums[i] - nums[mn]) >= valueDifference)
            return std::vector { mn, i };
    }

    return std::vector { -1, -1 };
}

#include "problem_2089.h"

bool problem_2089::test() {
    std::vector nums  { 1, 2, 5, 2, 3 };
    int target = 2;

    std::vector expected  { 1, 2 };

    auto result = targetIndices(nums, target);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2089::targetIndices(std::vector<int> &nums, int target) {
    int n = nums.size();
    int bigger = 0;
    int smaller = 0;
    for (auto num : nums)
    {
        if (num > target)
            bigger++;
        else if (num < target)
            smaller++;
    }
    int targeted = n - bigger - smaller;
    std::vector<int> result(targeted);
    for (int i = 0; i < targeted; ++i)
        result[i] = smaller + i;

    return result;
}

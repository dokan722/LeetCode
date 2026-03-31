#include "problem_2341.h"

bool problem_2341::test() {
    std::vector nums { 1, 3, 2, 1, 3, 2, 2 };

    std::vector expected { 3, 1 };

    auto result = numberOfPairs(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2341::numberOfPairs(std::vector<int> &nums) {
    int n = nums.size();
    std::vector present(101,false);
    int rem = n;
    for (auto num : nums)
    {
        if (present[num])
        {
            rem -= 2;
            present[num] = false;
        }
        else
            present[num] = true;
    }
    return  { (n - rem) / 2, rem };
}

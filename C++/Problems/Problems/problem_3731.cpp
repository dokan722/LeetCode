#include "problem_3731.h"

bool problem_3731::test() {
    std::vector nums { 1, 4, 2, 5 };

    std::vector expected { 3 };

    auto result = findMissingElements(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3731::findMissingElements(std::vector<int> &nums) {
    int mx = nums[0];
    int mn = nums[0];
    for (auto num : nums)
    {
        mx = std::max(mx, num);
        mn = std::min(mn, num);
    }
    int l = mx - mn + 1;
    std::vector<bool> present(l);
    for (auto num : nums)
        present[num - mn] = true;
    std::vector<int> result;
    for (int i = 0; i < l; ++i)
        if (!present[i])
            result.push_back(mn + i);
    return result;
}

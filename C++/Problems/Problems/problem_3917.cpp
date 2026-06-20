#include "problem_3917.h"

bool problem_3917::test() {
    std::vector nums { 1, 2, 3, 4 };

    std::vector expected { 2, 1, 1, 0 };

    auto result = countOppositeParity(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3917::countOppositeParity(std::vector<int> &nums) {
    int n = nums.size();
    int even = 0;
    int odd = 0;
    std::vector<int> result(n);
    for (int i = n - 1; i >= 0; --i)
    {
        if (nums[i] % 2 == 0)
        {
            result[i] = odd;
            even++;
        }
        else
        {
            result[i] = even;
            odd++;
        }
    }

    return result;
}

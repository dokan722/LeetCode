#include "problem_2553.h"

bool problem_2553::test() {
    std::vector nums { 13, 25, 83, 77 };

    std::vector expected { 1, 3, 2, 5, 8, 3, 7, 7 };

    auto result = separateDigits(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2553::separateDigits(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> result;
    for (int i = n - 1; i >= 0; --i)
    {
        int num = nums[i];
        while (num > 0)
        {
            result.push_back(num % 10);
            num /= 10;
        }
    }
    std::reverse(result.begin(), result.end());
    return result;
}

#include "problem_611.h"

#include <unordered_set>

bool problem_611::test() {
    std::vector nums { 4, 2, 3, 4 };

    int expected = 4;

    auto result = triangleNumber(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_611::triangleNumber(std::vector<int> &nums) {
    int n = nums.size();
    if (n < 3)
        return 0;
    std::vector counts(1001, 0);
    std::unordered_set<int> presentNums;
    for (int num : nums)
    {
        counts[num]++;
        presentNums.insert(num);
    }
    presentNums.erase(0);

    std::vector smallerOrEqual(1001, 0);
    smallerOrEqual[1] = counts[1];
    for (int i = 2; i <= 1000; ++i)
    {
        smallerOrEqual[i] = smallerOrEqual[i - 1] + counts[i];
    }

    long result = 0;
    for (int num1 : presentNums)
    {
        for (int num2 : presentNums)
        {
            int tooSmall = std::max(num1, num2) - std::min(num1, num2);
            int num3Poss = num1 + num2 > 1000 ? n - 2 : smallerOrEqual[num1 + num2 - 1] - 2;
            num3Poss -= smallerOrEqual[tooSmall] - (tooSmall >= std::min(num1, num2) ? 1 : 0);
            if (num1 != num2)
                result += counts[num1] * counts[num2] * num3Poss;
            else
                result += (counts[num1] - 1) * counts[num2] * num3Poss;

        }
    }

    return (int)(result / 6);
}

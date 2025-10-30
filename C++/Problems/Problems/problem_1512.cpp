#include "problem_1512.h"

#include <unordered_map>

bool problem_1512::test() {
    std::vector nums { 1, 2, 3, 1, 1, 3 };

    int expected = 4;

    int result = numIdenticalPairs(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1512::numIdenticalPairs(std::vector<int> &nums) {
    std::pmr::unordered_map<int, int> counts;
    int result = 0;
    for (auto num : nums)
    {
        if (counts.contains(num))
        {
            result += counts[num];
            counts[num]++;
        }
        else
            counts[num] = 1;
    }

    return result;
}

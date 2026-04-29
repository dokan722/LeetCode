#include "problem_1679.h"

#include <unordered_map>

bool problem_1679::test() {
    std::vector nums { 1, 2, 3, 4 };
    int k = 5;

    int expected = 2;

    auto result = maxOperations(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1679::maxOperations(std::vector<int> &nums, int k) {
    std::unordered_map<int, int> counts;
    int result = 0;
    for (auto num : nums)
    {
        if (counts.contains(num))
            counts[num]++;
        else
            counts[num] = 1;
        int req = k - num;
        if (req != num)
        {
            if (counts.contains(k - num) && counts[k - num] >= counts[num])
                result++;
        }
        else
        {
            if (counts[num] % 2 == 0)
                result++;
        }
    }

    return result;
}

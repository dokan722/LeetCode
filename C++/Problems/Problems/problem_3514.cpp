#include "problem_3514.h"

bool problem_3514::test() {
    std::vector nums { 6, 7, 8, 9 };

    int expected = 4;

    auto result = uniqueXorTriplets(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3514::uniqueXorTriplets(std::vector<int> &nums) {
    int mx = 0;
    for (auto num : nums)
        mx = std::max(num, mx);
    int s = 1;
    while (s <= mx)
        s <<= 1;
    std::vector one(s, false);
    std::vector two(s, false);
    std::vector three(s, false);
    for (auto num : nums)
    {
        one[num] = true;
        for (int i = 0; i < s; ++i)
            if (one[i])
                two[i ^ num] = true;
    }
    for (auto num : nums)
    {
        for (int i = 0; i < s; ++i)
            if (two[i])
                three[i ^ num] = true;
    }
    int result = 0;
    for (int i = 0; i < s; ++i)
        if (three[i])
            result++;
    return result;
}

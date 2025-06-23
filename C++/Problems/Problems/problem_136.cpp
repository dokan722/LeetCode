#include "problem_136.h"

#include <iostream>
#include <numeric>
#include <ostream>

bool problem_136::test() {
    std::vector nums { 2, 2, 1 };

    auto expected = 1;

    auto result = singleNumber(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_136::singleNumber(std::vector<int> &nums) {
    return std::accumulate(nums.begin(), nums.end(), 0, std::bit_xor());
}

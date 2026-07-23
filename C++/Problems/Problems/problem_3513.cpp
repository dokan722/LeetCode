#include "problem_3513.h"

bool problem_3513::test() {
    std::vector nums { 1, 2 };

    int expected = 2;

    auto result = uniqueXorTriplets(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3513::uniqueXorTriplets(std::vector<int> &nums) {
    int n = nums.size();
    if (n <= 2)
        return n;
    int num = 1;
    while (num <= n)
        num <<= 1;
    return num;
}

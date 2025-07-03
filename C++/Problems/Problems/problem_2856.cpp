#include "problem_2856.h"

#include <iostream>
#include <ostream>

bool problem_2856::test() {
    std::vector nums  { 1, 2, 3, 4 };

    auto expected = 0;

    auto result = minLengthAfterRemovals(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2856::minLengthAfterRemovals(std::vector<int> &nums) {
    int n = nums.size();
    if (n < 2)
        return n;
    auto left = 0;
    auto right = n - 1;
    auto med = nums[n / 2];
    while (nums[left] < med)
        left++;
    while (nums[right] > med)
        right--;
    auto lesser = left;
    auto bigger = n - 1 - right;
    auto equal = n - lesser - bigger;
    if (lesser + bigger > equal)
        return n % 2;


    return equal - lesser - bigger;
}

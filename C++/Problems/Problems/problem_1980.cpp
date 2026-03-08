#include "problem_1980.h"

bool problem_1980::test() {
    std::vector<std::string> nums  { "111", "011", "001" };

    std::string expected = "000";

    auto result = findDifferentBinaryString(nums);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1980::findDifferentBinaryString(std::vector<std::string> &nums) {
    int n = nums.size();
    std::string result = "";
    for (int i = 0; i < n; ++i)
    {
        result += nums[i][i] == '0' ? '1' : '0';
    }

    return result;
}

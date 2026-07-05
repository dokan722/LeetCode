#include "problem_3781.h"

bool problem_3781::test() {
    std::vector nums { 2, 1, 5, 2, 3 };
    std::string s = "01010";

    int expected = 7;

    auto result = maximumScore(nums, s);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3781::maximumScore(std::vector<int> &nums, std::string s) {
    int n = nums.size();
    std::priority_queue<int> queue;
    long result = 0;
    for (int i = 0; i < n; ++i)
    {
        queue.push(nums[i]);
        if (s[i] == '1')
        {
            int top = queue.top();
            queue.pop();
            result += top;
        }
    }
    return result;
}

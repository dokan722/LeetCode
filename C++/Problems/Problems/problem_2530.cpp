#include "problem_2530.h"

#include <queue>

bool problem_2530::test() {
    std::vector nums { 10, 10, 10, 10, 10 };
    int k = 5;

    int expected = 50;

    auto result = maxKelements(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2530::maxKelements(std::vector<int> &nums, int k) {
    std::priority_queue<int> queue;
    for (auto num : nums)
        queue.push(num);
    long result = 0;
    for (int i = 0; i < k; ++i)
    {
        int top = queue.top();
        queue.pop();
        result += top;
        int next = (top + 2) / 3;
        queue.push(next);
    }

    return result;
}

#include "problem_2233.h"

#include <queue>

bool problem_2233::test() {
    std::vector nums  {0, 4};
    int k = 5;

    int expected = 20;

    auto result = maximumProduct(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2233::maximumProduct(std::vector<int> &nums, int k) {
    if (nums.size() == 1)
        return nums[0] + k;
    std::priority_queue<int, std::vector<int>, std::greater<>> que;
    for (auto num : nums)
        que.push(num);
    while (k > 0)
    {
        int top = que.top();
        que.pop();
        int dif = std::min(k, que.top() + 1 - top);
        que.push(top + dif);
        k -= dif;
    }
    long result = 1;
    while (!que.empty())
    {
        result = result * que.top() % 1000000007;
        que.pop();
    }
    return (int)result;
}
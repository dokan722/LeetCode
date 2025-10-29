#include "problem_2593.h"

#include <queue>

bool problem_2593::test() {
    std::vector nums { 2, 1, 3, 4, 5, 2 };

    int expected = 7;

    int result = findScore(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2593::findScore(std::vector<int> &nums) {
    int n = nums.size();
    std::priority_queue<std::pair<int, int>> queue;
    std::vector marked(n + 2, false);
    for (int i = 0; i < n; i++)
        queue.push(std::pair(-nums[i], -i));

    long long result = 0;
    while (!queue.empty())
    {
        auto item = queue.top();
        queue.pop();
        auto id = -item.second;
        if (!marked[id+ 1])
        {
            marked[id] = true;
            marked[id + 1] = true;
            marked[id + 2] = true;
            result -= item.first;
        }
    }

    return result;
}

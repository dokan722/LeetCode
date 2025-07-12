#include "problem_2208.h"

#include <queue>

bool problem_2208::test() {
    std::vector nums { 5, 19, 8, 1 };

    auto expected = 3;

    auto result = halveArray(nums);

    return expected == result;
}

int problem_2208::halveArray(std::vector<int> &nums) {
    double initialSum = 0.0;
    std::priority_queue<double> queue;

    for (auto num : nums)
    {
        initialSum += num;
        queue.emplace(num);
    }

    int result = 0;
    auto sum = initialSum;
    while (sum > initialSum / 2)
    {
        auto max = queue.top();
        queue.pop();
        max /= 2;
        sum -= max;
        queue.emplace(max);
        result++;
    }

    return result;
}

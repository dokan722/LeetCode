#include "problem_3318.h"

#include <queue>

bool problem_3318::test() {
    std::vector nums { 3, 8, 7, 8, 7, 5 };
    int k = 2;
    int x = 2;

    std::vector expected { 11, 15, 15, 15, 12 };

    auto result = findXSum(nums, k, x);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_3318::findXSum(std::vector<int> &nums, int k, int x) {
    int n = nums.size();
    std::vector counts(51, 0);
    for (int i = 0; i < k; ++i)
        counts[nums[i]]++;

    int rLen = n - k + 1;
    std::vector<int> result(rLen);
    for (int i = 0; i < rLen; ++i)
    {
        int cRes = 0;
        std::priority_queue<std::pair<int, int>> que;
        for (int j = 0; j <= 50; ++j)
            if (counts[j] > 0)
                que.push(std::pair(counts[j], j));
        for (int j = 0; !que.empty() && j < x; ++j)
        {
            auto count = que.top();
            que.pop();
            cRes += count.first * count.second;
        }

        counts[nums[i]]--;
        if (i + k < n)
            counts[nums[i + k]]++;
        result[i] = cRes;
    }

    return result;
}


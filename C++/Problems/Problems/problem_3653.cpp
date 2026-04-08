#include "problem_3653.h"

bool problem_3653::test() {
    std::vector nums { 1, 1, 1 };
    std::vector<std::vector<int>> queries  {{ 0, 2, 1, 4 } };

    int expected = 4;

    auto result = xorAfterQueries(nums, queries);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3653::xorAfterQueries(std::vector<int> &nums, std::vector<std::vector<int>> &queries) {
    for (auto query : queries)
    {
        for (int i = query[0]; i <= query[1]; i += query[2])
        {
            long long x = (long long)nums[i] * query[3] % 1000000007;
            nums[i] = (int)x;
        }
    }

    int result = nums[0];
    for (int i = 1; i < nums.size(); ++i)
        result ^= nums[i];

    return result;
}

#include "problem_944.h"

bool problem_944::test() {
    std::vector<std::string> strs { "cba", "daf", "ghi" };

    int expected = 1;

    auto result = minDeletionSize(strs);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_944::minDeletionSize(std::vector<std::string> &strs) {
    int n = strs.size();
    int cols = strs[0].size();
    int result = 0;
    for (int i = 0; i < cols; ++i)
    {
        for (int j = 1; j < n; ++j)
        {
            if (strs[j - 1][i] > strs[j][i])
            {
                result++;
                break;
            }
        }
    }

    return result;
}

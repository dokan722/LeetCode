#include "problem_955.h"

bool problem_955::test() {
    std::vector<std::string> strs { "zyx", "wvu", "tsr" };

    int expected = 3;

    auto result = minDeletionSize(strs);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_955::minDeletionSize(std::vector<std::string> &strs) {
    int n = strs.size();
    int cols = strs[0].size();
    int result = 0;
    std::vector<std::string> curr(n, "");
    for (int i = 0; i < cols; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            curr[j] += strs[j][i];
        }

        bool sorted = true;
        for (int j = 1; j < n; ++j)
        {
            if (curr[j - 1] > curr[j])
            {
                sorted = false;
                break;
            }
        }

        if (!sorted)
        {
            result++;
            for (int j = 0; j < n; ++j)
            {
                curr[j].pop_back();
            }
        }
    }

    return result;
}

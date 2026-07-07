#include "problem_1072.h"

#include <unordered_map>

bool problem_1072::test() {
    std::vector<std::vector<int>> matrix {{ 0, 1 }, { 1, 0 } };

    int expected = 2;

    auto result = maxEqualRowsAfterFlips(matrix);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1072::maxEqualRowsAfterFlips(std::vector<std::vector<int>> &matrix) {
    int n = matrix.size();
    int m = matrix[0].size();
    int result = 0;
    std::unordered_map<std::string, int> counts;
    for (int i = 0; i < n; ++i)
    {
        std::string pat1 = "";
        std::string pat2 = "";
        for (int j = 0; j < m; ++j)
        {
            if (matrix[i][j] == 0)
            {
                pat1 += "0";
                pat2 += "1";
            }
            else
            {
                pat1 += "1";
                pat2 += "0";
            }
        }
        if (counts.contains(pat1))
            counts[pat1]++;
        else
            counts[pat1] = 1;
        if (counts.contains(pat2))
            counts[pat2]++;
        else
            counts[pat2] = 1;
        result = std::max(result, std::max(counts[pat1], counts[pat2]));
    }

    return result;
}

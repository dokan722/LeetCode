#include "problem_1605.h"

bool problem_1605::test() {
    std::vector rowSum { 3, 8 };
    std::vector colSum { 4, 7 };

    std::vector<std::vector<int>> expected { { 3, 0 }, { 1, 7 } };

    std::vector result = restoreMatrix(rowSum, colSum);


    return expected == result;
}

std::vector<std::vector<int>> problem_1605::restoreMatrix(std::vector<int> &rowSum, std::vector<int> &colSum) {
    int n = rowSum.size();
    int m = colSum.size();
    std::vector result(n, std::vector(m, 0));
    int i = 0;
    int j = 0;

    while (i < n && j < m)
    {
        int value = std::min(rowSum[i], colSum[j]);
        result[i][j] = value;
        rowSum[i] -= value;
        colSum[j] -= value;
        if (rowSum[i] == 0)
            i++;
        if (colSum[j] == 0)
            j++;
    }

    return result;
}

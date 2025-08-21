#include "problem_1504.h"

#include <stack>

bool problem_1504::test() {
    std::vector<std::vector<int>> mat {  { 1, 0, 1 },  { 1, 1, 0 },  { 1, 1, 0 } };

    auto expected = 13;

    auto result = numSubmat(mat);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1504::numSubmat(std::vector<std::vector<int>> &mat) {
    int n = mat.size();
    int m = mat[0].size();
    std::vector<int> columns(m);

    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        std::vector<int> rectangles(m);
        std::stack<int> prevColumns;
        for (int j = 0; j < m; ++j)
        {
            columns[j] = mat[i][j] == 0 ? 0 : columns[j] + 1;
            while (!prevColumns.empty() && columns[prevColumns.top()] >= columns[j])
                prevColumns.pop();
            if (!prevColumns.empty())
            {
                int smaller = prevColumns.top();
                rectangles[j] = rectangles[smaller] + columns[j] * (j - smaller);
            }
            else
                rectangles[j] = (j + 1) * columns[j];
            prevColumns.push(j);
            result += rectangles[j];
        }
    }

    return result;
}

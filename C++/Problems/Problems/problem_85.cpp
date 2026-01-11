#include "problem_85.h"

#include <stack>

bool problem_85::test() {
    std::vector<std::vector<char>> matrix =  {  { '1', '0', '1', '0', '0' },  { '1', '0', '1', '1', '1' },  { '1', '1', '1', '1', '1' },  { '1', '0', '0', '1', '0' } };

    int expected = 6;

    auto result = maximalRectangle(matrix);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_85::maximalRectangle(std::vector<std::vector<char>> &matrix) {
    int n = matrix.size();
    int m = matrix[0].size();
    std::vector h(m , 0);

    int result = 0;
    std::stack<int> stack;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (matrix[i][j] == '1')
                h[j]++;
            else
                h[j] = 0;

            while (!stack.empty() && h[stack.top()] > h[j])
            {
                int top = stack.top();
                stack.pop();
                int l = stack.size() == 0 ? j : j - stack.top() - 1;
                result = std::max(result, l * h[top]);
            }
            stack.push(j);
        }

        while (!stack.empty())
        {
            int top = stack.top();
            stack.pop();
            int l = stack.size() == 0 ? m : m - 1 - stack.top();
            result = std::max(result, l * h[top]);
        }
    }

    return result;
}

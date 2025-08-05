#include "problem_498.h"

bool problem_498::test() {
    std::vector<std::vector<int>> mat { {1, 2, 3},  {4, 5, 6},  {7, 8, 9}};

    std::vector expected { 1, 2, 4, 7, 5, 3, 6, 8, 9 };

    auto result = findDiagonalOrder(mat);

    return result == expected;
}

std::vector<int> problem_498::findDiagonalOrder(std::vector<std::vector<int>> &mat) {
    int n = mat.size();
    int m = mat[0].size();
    auto cap = std::max(n, m);  
    std::vector<int> result;

    auto x = 0;
    auto y = 0;
    for (int i = 0; i < 2 * cap - 1; ++i)
    {
        if (i % 2 == 1)
        {
            y = std::min(i, cap -1);
            x = std::max(0, i - cap + 1);
            while (x < cap && y >= 0)
            {
                if (x < n && y < m)
                    result.push_back(mat[x][y]);
                x++;
                y--;
            }
        }
        else
        {
            x = std::min(i, cap - 1);
            y = std::max(0, i - cap + 1);
            while (y < cap && x >= 0)
            {
                if (x < n && y < m)
                    result.push_back(mat[x][y]);
                y++;
                x--;
            }
        }
    }

    return result;
}

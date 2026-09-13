#include "problem_835.h"

bool problem_835::test() {
    std::vector<std::vector<int>> img1{ { 1, 1, 0 },{ 0, 1, 0 },{ 0, 1, 0 } };
    std::vector<std::vector<int>> img2 { { 0, 0, 0 }, { 0, 1, 1 }, { 0, 0, 1 } };

    int expected = 3;

    auto result = largestOverlap(img1, img2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_835::largestOverlap(std::vector<std::vector<int>> &img1, std::vector<std::vector<int>> &img2) {
    int n = img1.size();
    int ss = 2 * n - 1;
    std::vector result(ss, std::vector(ss, 0));
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            if (img2[i][j] == 0)
                continue;
            for (int k = 0; k < ss; ++k)
            {
                for (int l = 0; l < ss; ++l)
                {
                    int x = (i + k - n + 1);
                    int y = (j + l - n + 1);
                    if (x >= 0 && x < n && y >= 0 && y < n && img1[x][y] == 1)
                        result[k][l]++;
                }
            }
        }
    }

    int best = 0;
    for (int i = 0; i < ss; ++i)
    {
        for (int j = 0; j < ss; ++j)
            best = std::max(best, result[i][j]);
    }

    return best;
}
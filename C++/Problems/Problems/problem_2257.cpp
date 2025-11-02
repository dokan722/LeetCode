#include "problem_2257.h"

bool problem_2257::test() {
    int m = 4;
    int n = 6;
    std::vector<std::vector<int>> guards { { 0, 0 }, { 1, 1 }, { 2, 3 } };
    std::vector<std::vector<int>> walls { { 0, 1 }, { 2, 2 }, { 1, 4 } };

    int expected = 7;

    auto result = countUnguarded(m, n, guards, walls);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2257::countUnguarded(int m, int n, std::vector<std::vector<int>> &guards,
    std::vector<std::vector<int>> &walls) {
    std::vector<std::vector<int>> prison(m, std::vector<int>(n, 0));
    for (auto guard : guards)
        prison[guard[0]][guard[1]] = 2;
    for (auto wall : walls)
        prison[wall[0]][wall[1]] = 3;
    for (int i = 0; i < m; ++i)
    {
        bool state = false;
        for (int j = 0; j < n; ++j)
            state = checkCell(i, j, state, prison);
        state = false;
        for (int j = n - 1; j >= 0; --j)
            state = checkCell(i, j, state, prison);
    }
    for (int i = 0; i < n; ++i)
    {
        bool state = false;
        for (int j = 0; j < m; ++j)
            state = checkCell(j, i, state, prison);
        state = false;
        for (int j = m - 1; j >= 0; --j)
            state = checkCell(j, i, state, prison);
    }

    int result = 0;
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
            if (prison[i][j] == 0)
                result += 1;
    }

    return result;
}

bool problem_2257::checkCell(int i, int j, bool state, std::vector<std::vector<int>> &prison) {
    int val = prison[i][j];
    if (val == 2)
        state = true;
    else if (val == 3)
        state = false;
    else if (state)
        prison[i][j] = 1;
    return state;
}

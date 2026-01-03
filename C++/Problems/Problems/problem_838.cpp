#include "problem_838.h"

bool problem_838::test() {
    std::string dominoes = ".L.R...LR..L..";

    std::string expected = "LL.RR.LLRRLL..";

    auto result = pushDominoes(dominoes);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_838::pushDominoes(std::string dominoes) {
    int n = dominoes.size();
    std::vector right(n + 1, 0);
    std::vector left(n + 1, 0);
    for (int i = 1; i <= n; ++i)
    {
        if (dominoes[i - 1] == '.')
            right[i] = std::max(0, right[i - 1] - 1);
        else if (dominoes[i - 1] == 'R')
            right[i] = n;
        else
            right[i] = 0;
    }
    for (int i = n - 1; i >= 0; --i)
    {
        if (dominoes[i] == '.')
            left[i] = std::min(0, left[i + 1] + 1);
        else if (dominoes[i] == 'L')
            left[i] = -n;
        else
            left[i] = 0;
    }

    std::string result = "";
    for (int i = 0; i < n; ++i)
    {
        int val = right[i + 1] + left[i];
        if (val < 0)
            result += 'L';
        else if (val > 0)
            result += 'R';
        else
            result += '.';
    }

    return result;
}

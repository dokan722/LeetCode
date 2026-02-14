#include "problem_822.h"

bool problem_822::test() {
    std::vector fronts  { 1, 2, 4, 4, 7 };
    std::vector backs { 1, 3, 4, 1, 3 };

    int expected = 2;

    auto result = flipgame(fronts, backs);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_822::flipgame(std::vector<int> &fronts, std::vector<int> &backs) {
    int n = fronts.size();
    int maxVal = 2001;
    std::vector present(maxVal, false);
    std::vector impossible(maxVal, false);
    for (int i = 0; i < n; ++i)
    {
        present[fronts[i]] = true;
        present[backs[i]] = true;
        if (fronts[i] == backs[i])
            impossible[fronts[i]] = true;
    }
    int result = maxVal;
    for (int i = 1; i < maxVal; ++i)
    {
        if (present[i] && !impossible[i])
        {
            result = i;
            break;
        }
    }

    return result == maxVal ? 0 : result;
}

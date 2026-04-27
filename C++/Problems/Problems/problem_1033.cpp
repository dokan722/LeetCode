#include "problem_1033.h"

bool problem_1033::test() {
    int a = 1;
    int b = 2;
    int c = 5;

    std::vector expected { 1, 2 };

    auto result = numMovesStones(a, b, c);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1033::numMovesStones(int a, int b, int c) {
    std::vector s { a, b, c };
    std::sort(s.begin(), s.end());
    int left = s[1] - s[0] - 1;
    int right = s[2] - s[1] - 1;
    int m = 2;
    if (left == 0 && right == 0)
        m = 0;
    else if (left < 2 || right < 2)
        m = 1;
    return std::vector { m, left + right };
}

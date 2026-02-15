#include "problem_3290.h"

bool problem_3290::test() {
    std::vector a  { -1, 4, 5, -2 };
    std::vector b  { -5, -1, -3, -2, -4 };

    int expected = -1;

    auto result = maxScore(a, b);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3290::maxScore(std::vector<int> &a, std::vector<int> &b) {
    int n = b.size();
    std::vector result { (long long)100 * INT_MIN, (long long)100 * INT_MIN, (long long)100 * INT_MIN, (long long )100 * INT_MIN };
    for (int i = 0; i < n; ++i)
    {
        std::vector<long long> next(4);
        next[0] = std::max(result[0], (long long)a[0] * b[i]);
        next[1] = std::max(result[1], result[0] + (long long)a[1] * b[i]);
        next[2] = std::max(result[2], result[1] + (long long)a[2] * b[i]);
        next[3] = std::max(result[3], result[2] + (long long)a[3] * b[i]);
        result = next;
    }

    return result[3];
}

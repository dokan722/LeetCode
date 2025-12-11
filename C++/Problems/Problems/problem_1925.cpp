#include "problem_1925.h"

#include <unordered_set>

bool problem_1925::test() {
    int n = 10;

    int expected = 4;

    auto result = countTriples(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1925::countTriples(int n) {
    std::unordered_set<int> squares;
    for (int i = 1; i <=n; ++i)
        squares.insert(i * i);
    int result = 0;
    for (int i = 1; i <= n; ++i)
    {
        for (int j = 1; j <= n; ++j)
        {
            if (squares.contains(i * i + j * j))
                result++;
        }
    }

    return result;
}

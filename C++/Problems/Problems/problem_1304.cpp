#include "problem_1304.h"

#include <numeric>

bool problem_1304::test() {
    int n = 5;

    auto result = sumZero(n);

    return std::accumulate(result.begin(), result.end(), 0) == 0;
}

std::vector<int> problem_1304::sumZero(int n) {
    std::vector<int> result(n);
    result[0] = (n * (n - 1)) / 2;
    for (int i = 1; i < n; i++)
        result[i] = -i;

    return result;
}

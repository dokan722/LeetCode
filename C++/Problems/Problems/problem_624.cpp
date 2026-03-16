#include "problem_624.h"

bool problem_624::test() {
    std::vector<std::vector<int>> arrays { { 1, 2, 3 }, { 4, 5 }, { 1, 2, 3 } };

    int expected = 4;

    auto result = maxDistance(arrays);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_624::maxDistance(std::vector<std::vector<int>> &arrays) {
    int n = arrays.size();
    int smallest = arrays[0][0];
    int biggest = arrays[0][arrays[0].size() - 1];
    int result = 0;
    for (int i = 1; i < n; ++i)
    {
        int curSmall = arrays[i][0];
        int curBig = arrays[i][arrays[i].size() - 1];
        result = std::max(result, std::abs(curBig - smallest));
        result = std::max(result, std::abs(biggest - curSmall));
        smallest = std::min(smallest, curSmall);
        biggest = std::max(biggest, curBig);

    }
    return result;
}

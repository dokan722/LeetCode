#include "problem_3301.h"

bool problem_3301::test() {
    std::vector maximumHeight { 2, 3, 4, 3 };

    int expected = 10;

    int result = maximumTotalSum(maximumHeight);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3301::maximumTotalSum(std::vector<int> &maximumHeight) {
    int n = maximumHeight.size();
    std::sort(maximumHeight.begin(), maximumHeight.end());
    int threshold = INT_MAX;
    long result = 0;
    for (int i = n - 1; i >= 0; --i)
    {
        if (threshold < 1)
            return -1;
        int curr = std::min(maximumHeight[i], threshold);
        result += curr;
        threshold = curr - 1;
    }

    return result;
}

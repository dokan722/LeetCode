#include "problem_769.h"

bool problem_769::test() {
    std::vector arr { 1, 0, 2, 3, 4 };

    int expected = 4;

    auto result = maxChunksToSorted(arr);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_769::maxChunksToSorted(std::vector<int> &arr) {
    int n = arr.size();
    int m = -1;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        m = std::max(arr[i], m);
        if (m == i)
            result++;
    }

    return result;
}

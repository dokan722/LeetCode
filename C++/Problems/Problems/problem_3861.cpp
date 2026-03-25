#include "problem_3861.h"

bool problem_3861::test() {
    std::vector capacity {1, 5, 3, 7};
    int itemSize = 3;

    int expected = 2;

    auto result = minimumIndex(capacity, itemSize);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3861::minimumIndex(std::vector<int> &capacity, int itemSize) {
    int n = capacity.size();
    int minId = -1;
    for (int i = 0; i < n; ++i)
    {
        if (capacity[i] >= itemSize)
        {
            minId = i;
            break;
        }
    }
    if (minId == -1)
        return minId;
    for (int i = minId + 1; i < n; ++i)
    {
        if (capacity[i] >= itemSize && capacity[i] < capacity[minId])
            minId = i;
    }

    return minId;
}

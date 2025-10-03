#include "problem_42.h"

bool problem_42::test() {
    std::vector height { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

    int expected = 6;

    auto result = trap(height);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_42::trap(std::vector<int> &height) {
    int n = height.size();
    int maxId = 0;
    int result = 0;
    int waterCollected = 0;
    for (int i = 1; i < n; ++i)
    {
        if (height[i] >= height[maxId])
        {
            result += waterCollected;
            waterCollected = 0;
            maxId = i;
        }
        else
        {
            waterCollected += height[maxId] - height[i];
        }
    }

    int border = maxId;
    maxId = n - 1;
    waterCollected = 0;
    for (int i = n - 2; i >= border; --i)
    {
        if (height[i] >= height[maxId])
        {
            result += waterCollected;
            waterCollected = 0;
            maxId = i;
        }
        else
        {
            waterCollected += height[maxId] - height[i];
        }
    }

    return result;
}

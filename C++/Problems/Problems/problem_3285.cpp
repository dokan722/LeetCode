#include "problem_3285.h"

bool problem_3285::test() {
    std::vector height { 1, 2, 3, 4, 5 };
    int threshold = 2;

    std::vector expected { 3, 4 };

    auto result = stableMountains(height, threshold);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_3285::stableMountains(std::vector<int> &height, int threshold) {
    int n = height.size();
    std::vector<int> result;
    for (int i = 0; i < n - 1; ++i)
    {
        if (height[i] > threshold)
            result.push_back(i + 1);
    }

    return result;
}

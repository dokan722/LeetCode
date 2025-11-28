#include "problem_2951.h"

bool problem_2951::test() {
    std::vector mountain { 1, 4, 3, 8, 5 };

    std::vector expected { 1, 3 };

    auto result = findPeaks(mountain);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_2951::findPeaks(std::vector<int> &mountain) {
    int n = mountain.size();
    std::vector<int> result;
    for (int i = 1; i < n - 1; ++i)
    {
        if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
            result.push_back(i);
    }

    return result;
}

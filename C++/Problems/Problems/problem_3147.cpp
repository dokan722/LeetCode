#include "problem_3147.h"

bool problem_3147::test() {
    std::vector energy { 5, 2, -10, -5, 1 };
    int k = 3;

    int expected = 3;

    auto result = maximumEnergy(energy, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3147::maximumEnergy(std::vector<int> &energy, int k) {
    int n = energy.size();
    int result = INT_MIN;
    for (int i = 0; i < n; ++i)
    {
        if (i + k < n)
            energy[i + k] = std::max(energy[i + k], energy[i + k] + energy[i]);
        else
            result = std::max(result, energy[i]);
    }

    return result;
}

#include "problem_66.h"

bool problem_66::test() {
    std::vector digits { 1, 2, 3 };

    std::vector expected { 1, 2, 4 };

    auto result = plusOne(digits);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_66::plusOne(std::vector<int> &digits) {
    int n = digits.size();
    int i = n - 1;
    while (i >= 0 && digits[i] == 9)
        i--;
    if (i == -1)
    {
        std::vector result(n + 1, 0);
        result[0] = 1;
        return result;
    }

    digits[i]++;
    for (int j = i + 1; j < n; ++j)
        digits[j] = 0;

    return digits;
}


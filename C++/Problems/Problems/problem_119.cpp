#include "problem_119.h"

bool problem_119::test() {
    int rowIndex = 3;

    std::vector expected  { 1, 3, 3, 1 };

    auto result = getRow(rowIndex);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_119::getRow(int rowIndex) {
    std::vector result(rowIndex + 1, 0);
    result[0] = 1;
    result[rowIndex] = 1;
    for (int i = 1; i <= rowIndex; ++i)
    {
        int prev = result[0];
        for (int j = 1; j < rowIndex; ++j)
        {
            int curr = result[j];
            result[j] = prev + result[j];
            prev = curr;
        }
    }
    return result;
}

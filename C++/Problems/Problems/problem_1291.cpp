#include "problem_1291.h"

bool problem_1291::test() {
    int low = 100;
    int high = 300;

    std::vector expected  { 123, 234 };

    auto result = sequentialDigits(low, high);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1291::sequentialDigits(int low, int high) {
    std::vector<int> result;
    for (int i = 1; i < 10; ++i)
    {
        int num = 0;
        for (int j = i; j < 10; ++j)
        {
            num *= 10;
            num += j;
            if (num < low)
                continue;
            if (num <= high)
                result.push_back(num);
            else
                break;
        }
    }

    std::sort(result.begin(), result.end());
    return result;
}

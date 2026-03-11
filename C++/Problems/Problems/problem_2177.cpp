#include "problem_2177.h"

bool problem_2177::test() {
    int num = 33;

    std::vector<long long> expected  { 10, 11, 12 };

    auto result = sumOfThree(num);

    print1DVector(result);

    return expected == result;
}

std::vector<long long> problem_2177::sumOfThree(long long num) {
    if (num % 3 != 0)
        return std::vector<long long>();
    long long mid = num / 3;
    return std::vector<long long> { mid - 1, mid, mid + 1 };
}

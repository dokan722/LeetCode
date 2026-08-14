#include "problem_2178.h"

bool problem_2178::test() {
    int finalSum = 12;

    std::vector<long long> expected  { 2, 4, 6 };

    auto result = maximumEvenSplit(finalSum);

    print1DVector(result);

    return expected == result;
}

std::vector<long long> problem_2178::maximumEvenSplit(long long finalSum) {
    long long num = (long long)((std::sqrt(4 * finalSum + 1) - 1) / 2);
    std::vector<long long> result(num);
    for (int i = 0; i < num; ++i)
        result[i] = 2 * i + 2;
    int bonus = finalSum - 2 * (num * (num + 1) / 2);
    if (bonus % 2 == 1)
        return std::vector<long long> {};
    result[num - 1] += bonus;
    return result;
}

#include "problem_3723.h"

bool problem_3723::test() {
    int num = 2;
    int sum = 3;

    std::string expected = "30";

    auto result = maxSumOfSquares(num, sum);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_3723::maxSumOfSquares(int num, int sum) {
    if (9 * num < sum)
        return "";
    int nines = sum / 9;
    int rest = sum % 9;
    int zeros = num - nines - (rest == 0 ? 0 : 1);
    return std::string(nines, '9') + (rest == 0 ? "" : std::to_string(rest)) + std::string(zeros, '0');
}

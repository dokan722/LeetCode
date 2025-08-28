#include "problem_1894.h"

bool problem_1894::test() {
    std::vector chalk { 3, 4, 1, 2 };
    int k = 25;

    int expected = 1;

    auto result = chalkReplacer(chalk, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1894::chalkReplacer(std::vector<int> &chalk, int k) {
    long long sum = 0;
    for (int i = 0; i < chalk.size(); i++)
        sum += chalk[i];
    long long rest = k % sum;
    int child = 0;
    while (chalk[child] <= rest)
    {
        rest -= chalk[child];
        child++;
    }

    return child;
}

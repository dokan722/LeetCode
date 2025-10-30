#include "problem_1526.h"

bool problem_1526::test() {
    std::vector target { 3, 1, 5, 4, 2 };

    int expected = 7;

    int result = minNumberOperations(target);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1526::minNumberOperations(std::vector<int> &target) {
    int n = target.size();
    int result = target[0];
    for (int i = 1; i < n; ++i)
        result += std::max(0, target[i] - target[i - 1]);

    return result;
}

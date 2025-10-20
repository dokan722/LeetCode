#include "problem_2011.h"

bool problem_2011::test() {
    std::vector<std::string> operations { "--X", "X++", "X++" };
    int expected = 1;

    auto result = finalValueAfterOperations(operations);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2011::finalValueAfterOperations(std::vector<std::string> &operations) {
    int result = 0;
    for (auto o : operations)
    {
        if (o == "X++" || o == "++X")
            result++;
        else
            result--;
    }

    return result;
}

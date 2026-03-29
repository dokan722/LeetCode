#include "problem_412.h"

bool problem_412::test() {
    int n = 5;

    std::vector<std::string> expected { "1", "2", "Fizz", "4", "Buzz" };

    auto result = fizzBuzz(n);

    print1DVector(result);

    return expected == result;
}

std::vector<std::string> problem_412::fizzBuzz(int n) {
    std::vector<std::string> result(n);
    for (int i = 1; i <= n; ++i)
    {
        if (i % 15 == 0)
            result[i - 1] = "FizzBuzz";
        else if (i % 3 == 0)
            result[i - 1] = "Fizz";
        else if (i % 5 == 0)
            result[i - 1] = "Buzz";
        else
            result[i - 1] = std::to_string(i);
    }

    return result;
}

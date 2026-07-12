#include "problem_781.h"

bool problem_781::test() {
    std::vector answers { 1, 1, 2 };

    int expected = 5;

    auto result = numRabbits(answers);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_781::numRabbits(std::vector<int> &answers) {
    int result = 0;
    std::vector added(1002, 0);
    for (auto a : answers)
    {
        int act = a + 1;
        if (act == 1 || added[act] % act == 0)
        {
            result += act;
        }
        added[act]++;
    }

    return result;
}

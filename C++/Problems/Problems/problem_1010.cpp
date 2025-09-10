#include "problem_1010.h"

bool problem_1010::test() {
    std::vector time  { 30, 20, 150, 100, 40 };

    int expected = 3;

    int result = numPairsDivisibleBy60(time);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1010::numPairsDivisibleBy60(std::vector<int> &time) {
    int n = time.size();
    std::vector rests(60, 0);
    int result = 0;

    for (int i = 0; i < n; i++)
    {
        int rest = time[i] % 60;
        int expected = (60 - rest) % 60;
        result += rests[expected];
        rests[rest]++;
    }

    return result;
}

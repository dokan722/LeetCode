#include "problem_3751.h"

bool problem_3751::test() {
    int num1 = 120;
    int num2 = 130;

    int expected = 3;

    auto result = totalWaviness(num1, num2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3751::totalWaviness(int num1, int num2) {
    int result = 0;
    int start = std::max(100, num1);
    for (int i = start; i <= num2; ++i)
    {
        auto cur = std::to_string(i);
        int l = cur.size();
        for (int j = 1; j < l - 1; ++j)
        {
            if ((cur[j] < cur[j - 1] && cur[j] < cur[j + 1]) || (cur[j] > cur[j - 1] && cur[j] > cur[j + 1]))
                result++;
        }
    }

    return result;
}

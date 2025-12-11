#include "problem_1006.h"

bool problem_1006::test() {
    int n = 10;

    int expected = 12;

    auto result = clumsy(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1006::clumsy(int n) {
    int times = (n / 4) - 1;
    int rest = n % 4;
    int curr = 0;
    if (n >= 4)
    {
        curr += n * (n - 1) / (n - 2) + (n - 3);
        for (int i = 0; i < times; i++)
        {
            int num = n - (i + 1) * 4;
            curr -= num * (num - 1) / (num - 2) - (num - 3);
        }

        if (rest == 3)
            curr -= 6;
        else if (rest == 2)
            curr -= 2;
        else if (rest == 1)
            curr -= 1;
    }
    else
    {
        if (rest == 3)
            curr += 6;
        else if (rest == 2)
            curr += 2;
        else if (rest == 1)
            curr += 1;
    }

    return curr;
}

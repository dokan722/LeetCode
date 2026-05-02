#include "problem_788.h"

bool problem_788::test() {
    int n = 10;

    int expected = 4;

    auto result = rotatedDigits(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_788::rotatedDigits(int n) {
    int result = 0;

    for (int i = 1; i <= n; ++i)
    {
        int num = i;
        bool changed = false;
        while (num > 0)
        {
            int r = num % 10;
            if (r == 3 || r == 4 || r == 7)
            {
                changed = false;
                break;
            }
            if (r == 5 || r == 2 || r == 6 || r == 9)
                changed = true;
            num /= 10;
        }

        if (changed)
            result++;
    }

    return result;
}

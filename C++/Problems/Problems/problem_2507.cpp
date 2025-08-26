#include "problem_2507.h"

bool problem_2507::test() {
    int n = 15;

    int expected = 5;

    auto result = smallestValue(n);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2507::smallestValue(int n) {
    int next = n;
    int prev = 0;
    while (next > 0)
    {
        int i = 2;
        n = next;
        if (prev == next)
            return prev;
        prev = next;
        next = 0;
        auto limit = n / 2;
        while (i <= limit && n > 1)
        {
            if (n % i == 0)
            {
                n /= i;
                next += i;
                i = 2;
            }
            else
                i++;
        }
    }

    return n;
}

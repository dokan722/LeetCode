#include "problem_1009.h"

bool problem_1009::test() {
    int n = 10;

    int expected = 5;

    auto result = bitwiseComplement(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1009::bitwiseComplement(int n) {
    if (n == 0)
        return 1;
    int result = 0;
    int len = 0;
    while (n > 0)
    {
        if (n % 2 == 0)
        {
            result += 1 << len;
        }
        len++;
        n >>= 1;
    }
    return result;
}

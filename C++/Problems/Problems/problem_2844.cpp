#include "problem_2844.h"

bool problem_2844::test() {
    std::string num = "2245047";

    int expected = 2;

    auto result = minimumOperations(num);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2844::minimumOperations(std::string num) {
    bool zero = false;
    bool five = false;
    int zeros = 0;
    int n = num.size();
    for (int i = n - 1; i >= 0; --i)
    {
        if (zero && (num[i] == '5' || num[i] == '0'))
            return n - i - 2;
        if (five && (num[i] == '2' || num[i] == '7'))
            return n - i - 2;
        if (num[i] == '0')
        {
            zeros++;
            zero = true;
        }
        else if (num[i] == '5')
            five = true;
    }

    return n - zeros;
}

#include "problem_1404.h"

bool problem_1404::test() {
    std::string s = "1101";

    int expected = 6;

    auto result = numSteps(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1404::numSteps(std::string s) {
    int n = s.size();
    int carry = 0;
    int result = 0;
    for (int i = n - 1; i > 0; --i)
    {
        int curr = s[i] == '0' ? 0 : 1;
        int val = carry + curr;
        carry = val != 0 ? 1 : 0;
        if (val == 1)
            result += 2;
        else
            result++;
    }

    return result + carry;
}

#include "problem_67.h"

bool problem_67::test() {
    std::string a = "1010";
    std::string b = "1011";

    std::string expected = "10101";

    auto result = addBinary(a, b);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_67::addBinary(std::string a, std::string b) {
    int n = a.size();
    int m = b.size();
    int big = std::max(n, m);
    std::string result(big + 1, '0');
    int carry = 0;
    for (int i = 0; i <= big; ++i)
    {
        int first = i < n ? a[n - i - 1] - '0' : 0;
        int second = i < m ? b[m - i - 1] - '0' : 0;
        int total = carry + first + second;
        result[big - i] = (char)(total % 2 + '0');
        carry = total > 1 ? 1 : 0;
    }

    return result[0] == '0' ? result.substr(1) : result;
}

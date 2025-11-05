#include "problem_2027.h"

bool problem_2027::test() {
    std::string s = "XXOX";

    int expected = 2;

    auto result = minimumMoves(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2027::minimumMoves(std::string s) {
    int n = s.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == 'X')
        {
            result++;
            i += 2;
        }
    }
    return result;
}

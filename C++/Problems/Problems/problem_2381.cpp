#include "problem_2381.h"

bool problem_2381::test() {
    std::string s = "abc";
    std::vector<std::vector<int>> shifts { { 0, 1, 0 }, { 1, 2, 1 }, { 0, 2, 1 } };

    std::string expected = "ace";

    auto result = shiftingLetters(s, shifts);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_2381::shiftingLetters(std::string s, std::vector<std::vector<int>> &shifts) {
    int n = s.size();
    std::vector sweep(n + 1, 0);
    for (auto& shift : shifts)
    {
        int val = shift[2] == 1 ? 1 : -1;
        sweep[shift[0]] += val;
        sweep[shift[1] + 1] -= val;
    }
    int cur = 0;
    for (int i = 0; i < n; ++i)
    {
        cur += sweep[i];
        s[i] = (char)(((s[i] - 'a' + cur) % 26 + 26) % 26 + 'a');
    }

    return s;
}

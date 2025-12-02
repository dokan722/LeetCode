#include "problem_2405.h"

bool problem_2405::test() {
    std::string s = "abacaba";

    int expected = 4;

    auto result = partitionString(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2405::partitionString(std::string s) {
    int n = s.size();
    std::vector present(26, false);
    int result = 1;

    for (int i = 0; i < n; i++)
    {
        int id = s[i] - 'a';
        if (present[id])
        {
            result++;
            present = std::vector(26, false);
        }
        present[id] = true;
    }

    return result;
}

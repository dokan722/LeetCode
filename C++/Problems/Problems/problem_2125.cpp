#include "problem_2125.h"

bool problem_2125::test() {
    std::vector<std::string> bank { "011001", "000000", "010100", "001000" };

    int expected = 8;

    auto result = numberOfBeams(bank);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2125::numberOfBeams(std::vector<std::string> &bank) {
    int last = 0;
    int result = 0;
    for (auto row : bank)
    {
        int count = 0;
        for (auto c : row)
        {
            if (c == '1')
                count++;
        }

        if (count > 0)
        {
            result += last * count;
            last = count;
        }
    }

    return result;
}

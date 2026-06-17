#include "problem_2645.h"

bool problem_2645::test() {
    std::string word = "b";

    int expected = 2;

    auto result = addMinimum(word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2645::addMinimum(std::string word) {
    int prev = 0;
    int result = 0;
    for (auto c : word)
    {
        if (c == 'a')
        {
            if (prev == 0)
                prev++;
            else if (prev == 1)
                result += 2;
            else
            {
                result++;
                prev = 1;
            }
        }
        else if (c == 'b')
        {
            if (prev == 0)
            {
                result++;
                prev = 2;
            }
            else if (prev == 1)
                prev = 2;
            else
                result += 2;
        }
        else
        {
            if (prev == 0)
                result += 2;
            else if (prev == 1)
            {
                result++;
                prev = 0;
            }
            else
                prev = 0;
        }
    }

    return result + 'c' - word[word.size() - 1];
}

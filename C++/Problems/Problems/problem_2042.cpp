#include "problem_2042.h"

bool problem_2042::test() {
    std::string s = "1 box has 3 blue 4 red 6 green and 12 yellow marbles";

    auto expected = true;

    auto result = areNumbersAscending(s);

    return expected == result;
}

bool problem_2042::areNumbersAscending(std::string s) {
    int n = s.size();
    auto prev = -1;

    for (int i = 0; i < n; i++)
    {
        if (std::isdigit(s[i]))
        {
            auto end = i;
            while (end < n && std::isdigit(s[end]))
                end++;
            auto num = std::stoi(s.substr(i, end - i));
            if (num <= prev)
                return false;

            i = end;
            prev = num;
        }
    }

    return true;
}

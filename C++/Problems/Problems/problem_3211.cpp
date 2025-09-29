#include "problem_3211.h"

bool problem_3211::test() {
    int n = 3;

    int expected = 5;

    auto result = validStrings(n);

    return expected == result.size();
}

std::vector<std::string> problem_3211::validStrings(int n) {
    std::vector<std::string> result;
    result.push_back("0");
    result.push_back("1");
    for (int i = 1; i < n; i++)
    {
        std::vector<std::string> newResult;
        for (auto s : result)
        {
            newResult.push_back(s + "1");
            if (s[s.size() - 1]  == '1')
                newResult.push_back(s + "0");
        }

        result = newResult;
    }

    return result;
}

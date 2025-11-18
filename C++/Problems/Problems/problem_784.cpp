#include "problem_784.h"

bool problem_784::test() {
    std::string s = "a1b2";

    std::vector<std::string> expected { "a1b2", "a1B2", "A1b2", "A1B2" };

    auto result = letterCasePermutation(s);

    print1DVector(result);

    return result == expected;
}

std::vector<std::string> problem_784::letterCasePermutation(std::string s) {
    std::vector<std::string> result { "" };
    for (auto c : s)
    {
        if (std::isalpha(c))
        {
            std::vector<std::string> newResult;
            for (auto word : result)
            {
                newResult.push_back(word + (char)std::tolower(c));
                newResult.push_back(word + (char)std::toupper(c));
            }

            result = newResult;
        }
        else
        {
            std::vector<std::string> newResult;
            for (auto word : result)
            {
                newResult.push_back(word + c);
            }
            result = newResult;
        }
    }

    return result;
}

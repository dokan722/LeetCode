#include "problem_1807.h"

#include <unordered_map>

bool problem_1807::test() {
    std::string s = "(name)is(age)yearsold";
    std::vector<std::vector<std::string>> knowledge { { "name", "bob" }, { "age", "two" } };

    std::string expected = "bobistwoyearsold";

    auto result = evaluate(s, knowledge);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_1807::evaluate(std::string s, std::vector<std::vector<std::string>> &knowledge) {
    std::unordered_map<std::string, std::string> wordsDic;
    for (auto k : knowledge)
        wordsDic[k[0]] = k[1];
    std::string result;
    for (int i = 0; i < s.size(); i++)
    {
        if (s[i] == '(')
        {
            int start = i + 1;
            int end = start + 1;
            while (s[end] != ')')
                end++;
            std::string key = s.substr(start, end - start);
            if (wordsDic.contains(key))
                result += wordsDic[key];
            else
                result += "?";
            i = end;
        }
        else
            result += s[i];
    }

    return result;
}

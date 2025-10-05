#include "problem_1190.h"

#include <algorithm>
#include <stack>

bool problem_1190::test() {
    std::string s = "(ed(et(oc))el)";

    std::string expected = "leetcode";

    auto result = reverseParentheses(s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_1190::reverseParentheses(std::string s) {
    int n = s.size();
    std::stack<std::string> strings;
    int id = 0;
    for (int i = 0; i < n; i++)
    {
        if (s[i] == '(')
        {
            strings.push(s.substr(id, i - id));
            strings.push("(");
            id = i + 1;
        }
        else if (s[i] == ')')
        {
            std::string reversed = s.substr(id, i - id);
            std::reverse(reversed.begin(), reversed.end());
            while (!strings.empty() && strings.top() != "(") {
                auto temp = strings.top();
                strings.pop();
                std::reverse(temp.begin(), temp.end());
                reversed += temp;
            }
            strings.pop();
            strings.push(reversed);
            id = i + 1;
        }
    }

    std::vector<std::string> temp;
    if (id < n)
        temp.push_back(s.substr(id));
    while (!strings.empty()) {
        temp.push_back(strings.top());
        strings.pop();
    }

    std::string result;
    for (auto it = temp.rbegin(); it != temp.rend(); ++it)
        result += *it;
    return result;
}

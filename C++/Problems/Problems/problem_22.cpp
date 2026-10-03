#include "problem_22.h"

bool problem_22::test() {
    int n = 3;

    std::vector<std::string> expected { "()()()", "()(())", "(())()", "(()())", "((()))" };

    auto result = generateParenthesis(n);

    print1DVector(result);

    return expected == result;
}

std::vector<std::string> problem_22::generateParenthesis(int n) {
    std::vector<std::string> result;
    int l = 2 * n;
    generateRec(result, "", 0, l);
    return result;
}

void problem_22::generateRec(std::vector<std::string>& result, std::string cur, int d, int l) {
    if (l - cur.size() < d)
        return;
    if (cur.size() == l)
    {
        result.push_back(cur);
        return;
    }
    if (d != 0)
        generateRec(result, cur + ")", d - 1, l);
    generateRec(result, cur + "(", d + 1, l);
}

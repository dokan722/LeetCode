#include "problem_1415.h"

bool problem_1415::test() {
    int n = 3;
    int k = 9;

    std::string expected = "cab";

    auto result = getHappyString(n, k);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_1415::getHappyString(int n, int k) {
    std::vector chars { 'a', 'b', 'c' };
    std::vector<std::string> result {"a", "b", "c"};
    for (int i = 1; i < n; i++)
    {
        std::vector<std::string> newResult;
        for (auto s : result)
            for (auto c : chars)
        {
            if (c == s[s.size() - 1])
                continue;
            newResult.push_back(s + c);
        }
        result = newResult;
    }

    if (k > result.size())
        return "";

    return result[k - 1];
}

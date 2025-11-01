#include "problem_763.h"

bool problem_763::test() {
    std::string s = "ababcbacadefegdehijhklij";

    std::vector expected { 9, 7, 8 };

    auto result = partitionLabels(s);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_763::partitionLabels(std::string s) {
    int n = s.size();
    std::vector last(26, 0);
    for (int i = 0; i < n; ++i)
        last[s[i] - 'a'] = i;

    int start = -1;
    int end = 0;
    std::vector<int> result;
    for (int i = 0; i < n; ++i)
    {
        end = std::max(end, last[s[i] - 'a']);
        if (end == i)
        {
            result.push_back(end - start);
            start = i;
        }
    }

    return result;
}

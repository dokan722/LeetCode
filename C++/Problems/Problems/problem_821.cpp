#include "problem_821.h"

bool problem_821::test() {
    std::string s = "loveleetcode";
    char c = 'e';

    std::vector expected { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 };

    auto result = shortestToChar(s, c);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_821::shortestToChar(std::string s, char c) {
    int n = s.size();
    std::vector<int> result(n);
    int dist = n + 1;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == c)
            dist = 0;
        else
            dist++;
        result[i] = dist;
    }
    dist = n + 1;
    for (int i = n - 1; i >= 0; --i)
    {
        if (s[i] == c)
            dist = 0;
        else
            dist++;
        result[i] = std::min(result[i], dist);
    }

    return result;
}

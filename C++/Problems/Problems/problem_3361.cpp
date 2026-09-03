#include "problem_3361.h"

bool problem_3361::test() {
    std::string s = "abab";
    std::string t = "baba";
    std::vector nextCost  { 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    std::vector previousCost  { 1, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    int expected = 2;

    auto result = shiftDistance(s, t, nextCost, previousCost);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3361::shiftDistance(std::string s, std::string t, std::vector<int> &nextCost,
    std::vector<int> &previousCost) {
    long long result = 0;
    std::vector<long long> forw(27, 0);
    std::vector<long long> backw(27, 0);
    for (int i = 0; i < 26; ++i)
    {
        forw[i + 1] = nextCost[i] + forw[i];
        backw[i + 1] = previousCost[25 - i] + backw[i];
    }
    int n = s.size();
    for (int i = 0; i < n; ++i)
    {
        int x = s[i] - 'a';
        int y = t[i] - 'a';
        long long f = (x < y ? forw[y] - forw[x] : forw[26] - forw[x] + forw[y]);
        long long b = (x < y ? backw[26] - backw[25 - x] + backw[25 - y] : backw[25 - y] - backw[25 - x]);
        result += std::min(f, b);
    }

    return result;
}

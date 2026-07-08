#include "problem_3756.h"

bool problem_3756::test() {
    std::string s = "10203004";
    std::vector<std::vector<int>> queries { { 0, 7 }, { 1, 3 }, { 4, 6 } };

    std::vector expected { 12340, 4, 9 };

    auto result = sumAndMultiply(s, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3756::sumAndMultiply(std::string s, std::vector<std::vector<int>> &queries) {
    int n = s.size();
    int mod = 1000000007;
    std::vector<long long> mods(n + 1);
    std::vector<long long> sumPref(n + 1);
    std::vector<long long> vals(n + 1);
    std::vector<long long> lens(n + 1);
    mods[0] = 1;
    long curMod = 1;
    long curVal = 0;
    long l = 0;
    for (int i = 1; i <= n; ++i)
    {
        char c = s[i - 1];
        curMod = (curMod * 10) % mod;
        mods[i] = curMod;
        sumPref[i] = sumPref[i - 1] + c - '0';
        if (c != '0')
        {
            curVal = (curVal * 10 + c - '0') % mod;
            l++;
        }
        vals[i] = curVal;
        lens[i] = l;
    }

    int m = queries.size();
    std::vector<int> result(m);
    for (int i = 0; i < m; ++i)
    {
        auto q = queries[i];
        long long val = (((vals[q[1] + 1] - vals[q[0]] * mods[lens[q[1] + 1] - lens[q[0]]]) % mod) + mod) % mod;
        long long sm = sumPref[q[1] + 1] - sumPref[q[0]];
        result[i] = (int)((val * sm) % mod);
    }
    return result;
}

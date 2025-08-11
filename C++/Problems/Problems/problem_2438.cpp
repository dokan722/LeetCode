#include "problem_2438.h"



bool problem_2438::test() {
    auto n = 15;
    std::vector<std::vector<int>> queries {  { 0, 1 }, { 2, 2 }, { 0, 3 } };

    std::vector expected = { 2, 4, 64 };

    auto result = productQueries(n, queries);

    return result == expected;
}

std::vector _powersOfTwo
{
    1,
    2,
    4,
    8,
    16,
    32,
    64,
    128,
    256,
    512,
    1024,
    2048,
    4096,
    8192,
    16384,
    32768,
    65536,
    131072,
    262144,
    524288,
    1048576,
    2097152,
    4194304,
    8388608,
    16777216,
    33554432,
    67108864,
    134217728,
    268435456,
    536870912,
    1073741824
};

std::vector<int> problem_2438::productQueries(int n, std::vector<std::vector<int>> &queries) {
    int l = queries.size();
    std::vector result(l, 0);
    auto arr = getProblemArray(n);
    int k = arr.size();
    auto mod = 1000000007;
    std::vector proc(k, std::vector(k , 0));
    for (int i = 0; i < k; ++i)
    {
        proc[i][i] = arr[i];
        for (int j = i + 1; j < k; ++j)
            proc[i][j] = (int)((long long)proc[i][j - 1] * arr[j] % mod);
    }
    for (int i = 0; i < l; ++i)
        result[i] = proc[queries[i][0]][queries[i][1]];

    return result;
}

std::vector<int> problem_2438::getProblemArray(int n) {
    std::vector<int> result;
    auto bits = transformToBitArray(n);
    for (int i = 0; i < bits.size(); i++)
    {
        if (bits[30 - i] == 1)
            result.push_back(_powersOfTwo[i]);
    }

    return result;
}

std::vector<int> problem_2438::transformToBitArray(int num) {
    std::vector bits(31, 0);

    for (int i = 30; i >= 0; i--)
    {
        bits[30 - i] = (num >> i) & 1;
    }

    return bits;
}

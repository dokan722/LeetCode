#include "problem_1310.h"

bool problem_1310::test() {
    std::vector arr { 1, 3, 4, 8 };
    std::vector<std::vector<int>> queries  {  { 0, 1 },  { 1, 2 },  { 0, 3 },  { 3, 3 } };

    std::vector expected =  { 2, 7, 14, 8 };

    auto result = xorQueries(arr, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1310::xorQueries(std::vector<int> &arr, std::vector<std::vector<int>> &queries) {
    int n = arr.size();
    std::vector<int> pref(n + 1);
    pref[0] = 0;
    for (int i = 0; i < n; ++i)
        pref[i + 1] = pref[i] ^ arr[i];
    int m = queries.size();
    std::vector<int> result(m);
    for (int i = 0; i < m; ++i)
    {
        result[i] = pref[queries[i][0]] ^ pref[queries[i][1] + 1];
    }

    return result;
}

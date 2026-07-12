#include "problem_1331.h"

#include <unordered_map>

bool problem_1331::test() {
    std::vector arr { 40, 10, 20, 30 };

    std::vector expected { 4, 1, 2, 3 };

    auto result = arrayRankTransform(arr);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1331::arrayRankTransform(std::vector<int> &arr) {
    int n = arr.size();
    std::unordered_map<int, int> dic;
    auto sorted = arr;
    std::sort(sorted.begin(), sorted.end());
    int cur = 1;
    for (int i = 0; i < n; ++i)
    {
        if (!dic.contains(sorted[i]))
        {
            dic[sorted[i]] = cur;
            cur += 1;
        }
    }
    std::vector<int> result(n);
    for (int i = 0; i < n; ++i)
        result[i] = dic[arr[i]];

    return result;
}

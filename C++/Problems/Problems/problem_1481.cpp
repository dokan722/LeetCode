#include "problem_1481.h"

#include <unordered_map>

bool problem_1481::test() {
    std::vector arr { 5, 5, 4 };
    int k = 1;

    int expected = 1;

    auto result = findLeastNumOfUniqueInts(arr, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1481::findLeastNumOfUniqueInts(std::vector<int> &arr, int k) {
    std::unordered_map<int, int> counts;
    for (auto num : arr)
    {
        if (counts.contains(num))
            counts[num]++;
        else
            counts[num] = 1;
    }
    int m = counts.size();
    std::vector<int> freq;
    for (auto& p : counts)
        freq.push_back(p.second);
    std::sort(freq.begin(), freq.end());
    int end = 0;
    while (end < m && k >= freq[end])
    {
        k -= freq[end];
        end++;
    }
    return m - end;
}

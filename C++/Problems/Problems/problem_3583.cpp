#include "problem_3583.h"

#include <unordered_map>

bool problem_3583::test() {
    std::vector nums { 8, 4, 2, 8, 4 };

    int expected = 2;

    auto result = specialTriplets(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3583::specialTriplets(std::vector<int> &nums) {
    std::unordered_map<int, int> countsAll;
    std::unordered_map<int, int> countsCurr;
    int mod = 1000000007;
    for (auto num : nums)
    {
        if (countsAll.contains(num))
            countsAll[num]++;
        else
        {
            countsAll[num] = 1;
            countsCurr[num] = 0;
        }
    }

    long long result = 0;
    for (auto num : nums)
    {
        countsAll[num]--;
        int exp = 2 * num;
        if (countsAll.contains(exp))
            result = (result + (long long)countsAll[exp] * countsCurr[exp]) % mod;
        countsCurr[num]++;
    }

    return (int)result;
}

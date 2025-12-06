#include "problem_3578.h"

#include <set>
#include <unordered_map>

bool problem_3578::test() {
    std::vector nums { 9, 4, 1, 3, 7 };
    int k = 4;

    int expected = 6;

    auto result = countPartitions(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3578::countPartitions(std::vector<int> &nums, int k) {
    int n = nums.size();
    int mod = 1000000007;
    std::vector<long long> dp(n + 1);
    std::vector<long long> prefix(n + 1);

    std::set<int> cnt;
    std::unordered_map<int, int> freq;
    dp[0] = 1;
    prefix[0] = 1;

    for (int i = 0, j = 0; i < n; i++)
    {
        int num = nums[i];
        cnt.insert(num);
        if (freq.contains(num))
            freq[num] += 1;
        else
            freq[num] = 1;
        while (j <= i && *cnt.rbegin() - *cnt.begin() > k)
        {
            int key = nums[j];
            freq[key]--;
            if (freq[key] == 0)
            {
                cnt.erase(key);
                freq.erase(key);
            }
            j++;
        }

        dp[i + 1] = j > 0 ? (prefix[i] - prefix[j - 1] + mod) % mod : prefix[i];
        prefix[i + 1] = (prefix[i] + dp[i + 1]) % mod;
    }

    return (int)dp[n];
}

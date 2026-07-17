#include "problem_3312.h"

bool problem_3312::test() {
    std::vector nums { 2, 3, 4 };
    std::vector<long long> queries  { 0, 2, 2 };

    std::vector expected { 1, 2, 2 };

    auto result = gcdValues(nums, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3312::gcdValues(std::vector<int> &nums, std::vector<long long> &queries) {
    int n = nums.size();
    int mx = 0;
    for (int i = 0; i < n; ++i)
        mx = std::max(mx, nums[i]);
    std::vector freqs(mx + 1, 0);
    for (int i = 0; i < n; ++i)
        freqs[nums[i]]++;
    std::vector<int> gcds(mx + 1);
    for (int i = mx; i > 0; --i)
    {
        long pairs = 0;
        long bigger = 0;
        for (int j = i; j <= mx; j += i)
        {
            pairs += freqs[j];
            bigger += gcds[j];
        }
        gcds[i] = pairs * (pairs - 1) / 2 - bigger;
    }
    for (int i = 1; i <= mx; ++i)
        gcds[i] += gcds[i - 1];
    int m = queries.size();
    std::vector<int> result(m);

    for (int i = 0; i < m; ++i)
    {
        int l = 0;
        int r = mx;
        int val = queries[i] + 1;
        while (l < r)
        {
            int mid = (l + r) / 2;
            if (gcds[mid] < val)
                l = mid + 1;
            else
                r = mid;
        }

        result[i] = l;
    }

    return result;
}

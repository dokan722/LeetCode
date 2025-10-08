#include "problem_2300.h"

#include <algorithm>

bool problem_2300::test() {
    std::vector spells { 5, 1, 3 };
    std::vector potions { 1, 2, 3, 4, 5 };
    int success = 7;

    std::vector expected { 4, 0, 3 };

    auto result = successfulPairs(spells, potions, success);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_2300::successfulPairs(std::vector<int> &spells, std::vector<int> &potions, long long success) {
    int n = spells.size();
    int m = potions.size();
    std::sort(potions.begin(), potions.end());
    std::vector<int> result(n);
    for (int i = 0; i < n; ++i)
    {
        long long req = (success + spells[i] - 1) / spells[i];
        if (potions[0] >= req)
            result[i] = m;
        else if (potions[m - 1] < req)
            result[i] = 0;
        else
        {
            int left = 0;
            int right = m - 1;
            while (left < right)
            {
                int mid = (left + right + 1) / 2;
                if (potions[mid] >= req)
                    right = mid - 1;
                else
                    left = mid;
            }

            result[i] = m - left - 1;
        }
    }

    return result;
}

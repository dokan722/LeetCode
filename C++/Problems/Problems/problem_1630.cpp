#include "problem_1630.h"

bool problem_1630::test() {
    std::vector nums { 1, 2, 10, -6, -7, 8, 16, 0, 0, 10, 20, 15, -2, -3, -1, -4, -4, -8, -2 };
    std::vector l { 14, 5, 11, 15, 12, 13, 9, 7, 0 };
    std::vector r { 15, 8, 14, 18, 15, 16, 12, 8, 1 };

    std::vector expected { true,false,false,false,true,false,false,true,true };

    auto result = checkArithmeticSubarrays(nums, l, r);

    print1DVector(result);

    return expected == result;
}

std::vector<bool> problem_1630::checkArithmeticSubarrays(std::vector<int> &nums, std::vector<int> &l, std::vector<int> &r) {
    int m = l.size();
    std::vector result(m , false);
    for (int i = 0; i < m; ++i)
    {
        int mn = INT_MAX;
        int mx = INT_MIN;
        for (int j = l[i]; j <= r[i]; ++j)
        {
            mn = std::min(mn, nums[j]);
            mx = std::max(mx, nums[j]);
        }
        int ln = r[i] - l[i] + 1;
        if (mn == mx)
            result[i] = true;
        else if ((mx - mn) % (ln - 1) == 0)
        {
            std::vector present(ln, false);
            bool res = true;
            int d = (mx - mn) / (ln - 1);
            for (int j = l[i]; j <= r[i]; ++j)
            {
                if ((nums[j] - mn) % d != 0 || present[(nums[j] - mn) / d])
                {
                    res = false;
                    break;
                }

                present[(nums[j] - mn) / d] = true;

            }
            result[i] = res;
        }
    }
    return result;
}

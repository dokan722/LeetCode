#include "problem_300.h"

bool problem_300::test() {
    std::vector nums  { 10, 9, 2, 5, 3, 7, 101, 18 };

    int expected = 4;

    auto result = lengthOfLIS(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_300::lengthOfLIS(std::vector<int> &nums) {
    std::vector<int> subs;
    for (auto num : nums)
    {
        int l = 0;
        int r = subs.size() - 1;
        int mid = 0;
        while (l <= r)
        {
            mid = (l + r) / 2;
            if (num > subs[mid])
                l = mid + 1;
            else
                r = mid - 1;
        }
        if (l == subs.size())
            subs.push_back(num);
        else
            subs[l] = num;
    }

    return subs.size();
}

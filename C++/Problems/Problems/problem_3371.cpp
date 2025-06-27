#include "problem_3371.h"

#include <climits>
#include <unordered_map>

bool problem_3371::test() {
    std::vector nums  {2, 3, 5, 10};

    auto expected = 10;

    auto result = getLargestOutlier(nums);

    return expected == result;
}

int problem_3371::getLargestOutlier(std::vector<int> &nums) {
    auto sum = 0;
    std::pmr::unordered_map<int, int> dic;
    for (auto num : nums)
    {
        sum += num;
        if (dic.contains(num))
            dic[num]++;
        else
            dic[num] = 1;
    }
    auto result = INT_MIN;
    for (auto num : nums)
    {
        if ((sum - num) % 2 == 0 && dic.contains((sum - num) / 2) && ((sum - num) / 2 != num || dic[num] > 1))
        {
            if (num > result)
                result = num;
        }
    }

    return result;
}

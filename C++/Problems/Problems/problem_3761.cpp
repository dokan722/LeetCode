#include "problem_3761.h"

#include <unordered_map>

bool problem_3761::test() {
    std::vector nums { 12, 21, 45, 33, 54 };

    int expected = 1;

    auto result = minMirrorPairDistance(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3761::minMirrorPairDistance(std::vector<int> &nums) {
    int n = nums.size();
    int result = INT_MAX;
    std::unordered_map<int, int> last;
    for (int i = 0; i < n; ++i)
    {
        int num = nums[i];
        if (last.contains(num))
            result = std::min(result, i - last[num]);

        int rev = 0;
        while (num > 0)
        {
            rev *= 10;
            rev += num % 10;
            num /= 10;
        }
        last[rev] = i;
    }

    return result == INT_MAX ? -1 : result;
}

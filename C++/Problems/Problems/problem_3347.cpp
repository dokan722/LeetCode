#include "problem_3347.h"

#include <algorithm>

bool problem_3347::test() {
    std::vector nums { 33, 3, 86, 86, 114 };
    int k = 20;
    int numOperations = 4;

    int expected = 3;

    int result = maxFrequency(nums, k, numOperations);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3347::maxFrequency(std::vector<int>& nums, int k, int numOperations) {
    std::sort(nums.begin(), nums.end());
    int n = nums.size();
    int left = 0;
    int leftBig = 0;
    int right = 0;
    int rightBig = 0;
    int curr = 0;
    int result = 0;
    while (curr < n)
    {
        int val = nums[curr];
        int start = curr;
        while (curr < n && nums[curr] == val)
            curr++;
        while (right < n && nums[right] <= val + k)
            right++;
        while (rightBig < n && nums[rightBig] <= val + k * 2)
            rightBig++;
        while (nums[left] < val - k)
            left++;
        while (nums[leftBig] < val - 2 * k)
            leftBig++;
        int currLen = curr - start;
        int inRange = right - left;
        int inRangeLeft = curr - leftBig;
        int inRangeRight = rightBig - start;
        int makeEqual = currLen + std::min(numOperations, inRange - currLen);
        int makeOther = std::min(numOperations, std::max(inRangeLeft, inRangeRight));
        result = std::max(result, std::max(makeEqual, makeOther));
    }

    return result;
}

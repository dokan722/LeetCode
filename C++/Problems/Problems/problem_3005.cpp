#include "problem_3005.h"

#include <unordered_map>

bool problem_3005::test() {
    std::vector nums { 1, 2, 2, 3, 1, 4 };

    int expected = 4;

    auto result = maxFrequencyElements(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3005::maxFrequencyElements(std::vector<int> &nums) {
    std::pmr::unordered_map<int, int> freq;
    int maxFreq = 0;
    int result = 0;
    for (auto num : nums)
    {
        if (freq.contains(num))
            freq[num]++;
        else
            freq[num] = 1;
        if (freq[num] > maxFreq)
        {
            maxFreq = freq[num];
            result = maxFreq;
        }
        else if (freq[num] == maxFreq)
            result += maxFreq;
    }

    return result;
}

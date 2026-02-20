#include "problem_2023.h"

#include <unordered_map>

bool problem_2023::test() {
    std::vector<std::string> nums  { "777", "7", "77", "77" };
    std::string target = "7777";

    int expected = 4;

    auto result = numOfPairs(nums, target);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2023::numOfPairs(std::vector<std::string> &nums, std::string target) {
    int tl = target.size();
    int result = 0;
    std::unordered_map<std::string, int> parts;
    for (auto& num : nums)
    {
        int l = num.size();
        if (l > tl)
            continue;
        if (num == target.substr(0, l))
        {
            auto suf = target.substr(l, tl - l);
            auto sufs = parts.contains(suf) ? parts[suf] : 0;
            result += sufs;
        }
        if (num == target.substr(tl - l, l))
        {
            auto pref = target.substr(0, tl - l);
            auto prefs = parts.contains(pref) ? parts[pref] : 0;
            result += prefs;
        }
        if (parts.contains(num))
            parts[num]++;
        else
            parts[num] = 1;
    }

    return result;
}

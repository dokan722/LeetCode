#include "problem_3.h"
#include <unordered_map>


bool problem_3::test() {
    auto s = "alouzxilkaxkufsu";

    auto expected = 8;;

    auto result = lengthOfLongestSubstring(s);

    return expected == result;
}

int problem_3::lengthOfLongestSubstring(std::string s) {
    auto partsDic = std::unordered_map<char, int>();

    auto longest = 0;
    auto currLen = 0;
    for (int i = 0; i < s.size(); ++i)
    {
        currLen++;
        auto it = partsDic.find(s[i]);
        if (it != partsDic.end())
        {
            auto dist = i - it->second;
            if (dist <= currLen)
            {
                currLen = dist;
            }
            if (currLen > longest)
                longest = currLen;
        }
        else
        {
            if (currLen > longest)
                longest = currLen;
        }
        partsDic[s[i]] = i;
    }

    if (currLen > longest)
        longest = currLen;

    return longest;
}

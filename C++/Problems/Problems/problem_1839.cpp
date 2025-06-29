#include "problem_1839.h"

#include <iostream>
#include <ostream>
#include <vector>

bool problem_1839::test() {
    auto word = "aeiaaioaaaaeiiiiouuuooaauuaeiu";

    auto expected = 13;

    auto result = longestBeautifulSubstring(word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1839::longestBeautifulSubstring(std::string word) {
    auto maxLen = 0;
    auto nextReq = -1;
    auto l = 0;
    std::vector vowels { 'a', 'e', 'i', 'o', 'u' };
    for (auto c : word)
    {
        if (c == 'u' && nextReq == 4)
        {
            l++;
            if (l > maxLen)
                maxLen = l;
        }
        else if (nextReq != -1 && c == vowels[nextReq])
        {
            l++;
        }
        else if (nextReq < 4 && c == vowels[nextReq + 1])
        {
            l++;
            nextReq++;
            if (c == 'u' && nextReq == 4)
            {
                if (l > maxLen)
                    maxLen = l;
            }
        }
        else
        {
            nextReq = -1;
            l = 0;
            if (c == 'a')
            {
                nextReq++;
                l++;
            }
        }
    }

    return maxLen;
}

#include "problem_3517.h"

#include <algorithm>

bool problem_3517::test() {
    std::string s = "babab";

    std::string expected = "abbba";

    auto result = smallestPalindrome(s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_3517::smallestPalindrome(std::string s) {
    int n = s.size();
    bool isOdd = n % 2 == 1;
    std::vector count(26, 0);
    for (auto c : s)
        count[c - 'a']++;
    std::string middle = "";
    if (isOdd)
    {
        for (int i = 0; i < 26; ++i)
        {
            if (count[i] % 2 == 1)
            {
                middle += (char)(i + 'a');
                break;
            }
        }
    }

    std::string half = "";
    for (int i = 0; i < 26; ++i)
    {
        half += std::string(count[i] / 2, (char)(i + 'a'));
    }
    std::string otherHalf = half;
    std::reverse(otherHalf.begin(), otherHalf.end());
    return half + middle + otherHalf;
}

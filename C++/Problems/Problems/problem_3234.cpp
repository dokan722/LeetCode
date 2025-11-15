#include "problem_3234.h"

bool problem_3234::test() {
    std::string s = "00011";

    int expected = 5;

    auto result = numberOfSubstrings(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3234::numberOfSubstrings(std::string s) {
    int n = s.size();
    std::vector<int> ids(n + 1);
    ids[0] = -1;
    for (int i = 0; i < n; i++)
    {
        if (i == 0 || s[i - 1] == '0')
            ids[i + 1] = i;
        else
            ids[i + 1] = ids[i];
    }
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        int zeros = s[i - 1] == '0' ? 1 : 0;
        int j = i;
        while (j > 0 && zeros * zeros <= n)
        {
            int ones = (i - ids[j]) - zeros;
            if (zeros * zeros <= ones)
            {
                result += std::min(j - ids[j], ones - zeros * zeros + 1);
            }
            j = ids[j];
            zeros++;
        }
    }
    return result;
}


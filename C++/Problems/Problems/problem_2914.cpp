#include "problem_2914.h"

bool problem_2914::test() {
    std::string s = "1001";

    int expected = 2;

    auto result = minChanges(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2914::minChanges(std::string s) {
    int n = s.size();
    int start = 0;
    char curr = s[0];
    int result = 0;
    for (int i = 0; i < n; i++)
    {
        if (s[i] != curr)
        {
            int len = i - start;
            if (len % 2 != 0)
            {
                result++;
                i++;
            }
            start = i;
            if (i < n)
                curr = s[i];
        }
    }

    return result;
}

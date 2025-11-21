#include "problem_443.h"

bool problem_443::test() {
    std::vector chars { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };

    int expected1 = 6;
    auto result = compress(chars);

    std::cout << result << std::endl;

    return result == expected1;
}

int problem_443::compress(std::vector<char> &chars) {
    int n = chars.size();
    if (n < 2)
        return n;
    int j = 0;
    int start = 0;
    for (int i = 1; i < n; ++i)
    {
        if (chars[i] != chars[i - 1])
        {
            int l = i - start;
            chars[j] = chars[i - 1];
            j++;
            if (l > 1)
            {
                for (auto digit : std::to_string(l))
                {
                    chars[j] = digit;
                    j++;
                }
            }

            start = i;
        }
    }
    int fl = (n - start);
    chars[j] = chars[n - 1];
    j++;
    if (fl > 1)
    {
        for (auto digit : std::to_string(fl))
        {
            chars[j] = digit;
            j++;
        }
    }

    return j;
}

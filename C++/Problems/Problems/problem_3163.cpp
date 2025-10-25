#include "problem_3163.h"

bool problem_3163::test() {
    std::string word = "aaaaaaaaaaaaaabb";

    std::string expected = "9a5a2b";

    auto result = compressedString(word);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_3163::compressedString(std::string word) {
    int n = word.size();
    int start = 0;
    char curr = word[0];
    std::string result = "";
    for (int i = 1; i < n; i++)
    {
        if (curr != word[i])
        {
            int l = i - start;
            int full = l / 9;
            int rest = l % 9;
            std::string part = std::string("9") + curr;
            for (int i = 0; i < full; ++i)
                result += part;
            if (rest != 0) {
                result += (char)('0' + rest);
                result += curr;
            }
            curr = word[i];
            start = i;
        }
    }
    int fl = n - start;
    int ffull = fl / 9;
    int frest = fl % 9;
    std::string part = std::string("9") + curr;
    for (int i = 0; i < ffull; ++i)
        result += part;
    if (frest != 0) {
        result += (char) ('0' + frest);
        result += curr;
    }


    return result;
}

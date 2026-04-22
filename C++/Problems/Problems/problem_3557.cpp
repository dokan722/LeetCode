#include "problem_3557.h"

#include <unordered_map>

bool problem_3557::test() {
    std::string word = "abcdeafdef";

    int expected = 2;

    auto result = maxSubstrings(word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3557::maxSubstrings(std::string word) {
    int n = word.size();
    std::unordered_map<char, int> last;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (last.contains(word[i]))
        {
            if (i - last[word[i]] >= 3)
            {
                result++;
                last.clear();
            }
        }
        else
            last[word[i]] = i;
    }
    return result;
}

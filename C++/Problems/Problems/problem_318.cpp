#include "problem_318.h"

bool problem_318::test() {
    std::vector<std::string> words { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" };

    int expected = 16;

    auto result = maxProduct(words);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_318::maxProduct(std::vector<std::string> &words) {
    int n = words.size();
    int result = 0;
    std::vector<int> masks(n);
    for (int i = 0; i < n; ++i)
    {
        int mask = 0;
        for (auto c : words[i])
            mask |= 1 << (c - 'a');
        masks[i] = mask;
    }
    for (int i = 0; i < n; ++i)
    {

        for (int j = i + 1; j < n; ++j)
        {
            if ((masks[i] & masks[j]) == 0)
            {
                result = std::max(result, (int)words[i].size() * (int)words[j].size());
            }
        }
    }

    return result;
}

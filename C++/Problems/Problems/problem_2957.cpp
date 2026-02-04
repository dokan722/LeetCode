#include "problem_2957.h"

bool problem_2957::test() {
    std::string word = "zyxyxyz";

    int expected = 3;

    auto result = removeAlmostEqualCharacters(word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2957::removeAlmostEqualCharacters(std::string word) {
    int n = word.size();
    std::vector changed(n, false);
    int count = 0;
    for (int i = 1; i < n; ++i)
    {
        if (!changed[i - 1] && std::abs(word[i] - word[i - 1]) < 2)
        {
            count++;
            changed[i] = true;
        }
    }

    return count;
}

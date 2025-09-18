#include "problem_2108.h"

bool problem_2108::test() {
    std::vector<std::string> words { "abc", "car", "ada", "racecar", "cool" };

    std::string expected = "ada";

    auto result = firstPalindrome(words);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_2108::firstPalindrome(std::vector<std::string> &words) {
    for (auto word : words)
    {
        int half = word.size() / 2;
        bool isPal = true;
        for (int i = 0; i < half; i++)
        {
            if (word[i] != word[word.size() - i - 1])
            {
                isPal = false;
                break;
            }
        }
        if (isPal)
            return word;
    }

    return "";
}

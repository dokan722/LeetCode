#include "problem_3136.h"

#include <set>

bool problem_3136::test() {
    std::string word = "234Adas";

    auto expected = true;

    auto result = isValid(word);

    return expected == result;
}

bool problem_3136::isValid(std::string word) {
    if (word.size() < 3)
        return false;
    std::set vowels { 'a', 'e', 'i', 'o', 'u' };
    auto haveVowel = false;
    auto haveCons = false;
    for (char c : word)
    {
        if (vowels.contains(std::tolower(c)))
            haveVowel = true;
        else if (std::isalpha(c))
            haveCons = true;
        else if (!std::isdigit(c))
            return false;
    }

    return haveCons && haveVowel;
}

#include "problem_744.h"

bool problem_744::test() {
    std::vector letters { 'c', 'f', 'j'};
    char target = 'c';

    char expected = 'f';

    auto result = nextGreatestLetter(letters, target);

    std::cout << result << std::endl;

    return result == expected;
}

char problem_744::nextGreatestLetter(std::vector<char> &letters, char target) {
    int left = 0;
    int right = letters.size() - 1;
    if (letters[right] <= target)
        return letters[0];
    while (left < right)
    {
        int mid = (left + right) / 2;
        if (letters[mid] <= target)
            left = mid + 1;
        else
            right = mid;
    }

    return letters[left];
}

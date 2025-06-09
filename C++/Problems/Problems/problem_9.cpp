#include "problem_9.h"

#include <algorithm>
#include <iostream>
#include <ostream>
#include <ranges>


bool problem_9::test() {
    auto n = 121;

    auto expected = true;

    auto result = isPalindrome(n);

    std::cout << result << std::endl;

    return expected == result;
}

bool problem_9::isPalindrome(int x) {
    auto num = std::to_string(x);
    auto len = num.size();
    auto first = num.substr(0, len / 2);
    auto last = num.substr(len - len / 2, len / 2);
    std::ranges::reverse(last);

    return first == last;
}

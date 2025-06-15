#include "problem_1432.h"

#include <algorithm>
#include <iostream>
#include <ostream>

bool problem_1432::test() {
    auto num = 555;

    auto expected = 888;

    auto result = maxDiff(num);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1432::maxDiff(int num) {
    auto numsString = std::to_string(num);
    int swapToMin = 0;
    int swapToMax = 0;

    for (; swapToMin < numsString.size(); swapToMin++) {
        if (numsString[swapToMin] != '0' && numsString[swapToMin] != '1')
            break;
    }

    for (; swapToMax < numsString.size(); swapToMax++) {
        if (numsString[swapToMax] != '9')
            break;
    }
    std::string max = numsString;
    std::string min = numsString;
    auto swapToMinC = numsString[swapToMin];
    auto swapToMaxC = numsString[swapToMax];
    if (swapToMin < numsString.size())
        std::replace(min.begin(), min.end(), swapToMinC, swapToMinC == numsString[0] ? '1' : '0');

    if (swapToMax < numsString.size())
        std::replace(max.begin(), max.end(), swapToMaxC, '9');


    return std::stoi(max) - std::stoi(min);
}

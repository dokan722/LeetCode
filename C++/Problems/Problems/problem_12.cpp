#include "problem_12.h"

#include <iostream>
#include <ostream>

bool problem_12::test() {
    auto num = 3749;

    std::string expected = "MMMDCCXLIX";

    auto result = intToRoman(num);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_12::intToRoman(int num) {
    auto numString = std::to_string(num);
    std::string result = "";

    if (numString.size() == 4)
    {
        result += std::string(numString[0] - '0', 'M');
        numString = numString.substr(1);
    }


    if (numString.size() == 3)
    {
        appendStuff(result, 'C', 'D', 'M', numString[0]);
        numString = numString.substr(1);
    }

    if (numString.size() == 2)
    {
        appendStuff(result, 'X', 'L', 'C', numString[0]);
        numString = numString.substr(1);
    }

    if (numString.size() == 1)
    {
        appendStuff(result, 'I', 'V', 'X', numString[0]);
        numString = numString.substr(1);
    }


    return result;
}

void problem_12::appendStuff(std::string &result, char one, char five, char dec, char src) {
    if (src < '4')
        result += std::string(src - '0', one);
    else if (src == '4') {
        result.push_back(one);
        result.push_back(five);
    }
    else if (src < '9') {
        result.push_back(five);
        result += std::string(src - '0' - 5, one);
    }
    else {
        result.push_back(one);
        result.push_back(dec);
    }
}



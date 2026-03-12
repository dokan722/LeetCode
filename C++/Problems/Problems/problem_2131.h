#ifndef PROBLEMS_PROBLEM_2131_H
#define PROBLEMS_PROBLEM_2131_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2131 : public problem {
public:
    bool test() override;

    int longestPalindrome(std::vector<std::string>& words);
};

#endif //PROBLEMS_PROBLEM_2131_H
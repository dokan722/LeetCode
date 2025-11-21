#ifndef PROBLEM_1930_H
#define PROBLEM_1930_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1930 : public problem {
public:
    bool test() override;

    int countPalindromicSubsequence(std::string s);
};



#endif //PROBLEM_1930_H

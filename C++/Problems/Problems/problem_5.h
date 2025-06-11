#ifndef PROBLEM_5_H
#define PROBLEM_5_H

#include "../problem.h"
#include <string>

class problem_5 : public problem
{
public:
    bool test() override;

    std::string longestPalindrome(std::string s);
private:
    int checkOdd(std::string s, int i);
    int checkEven(std::string s, int i);
};


#endif //PROBLEM_5_H

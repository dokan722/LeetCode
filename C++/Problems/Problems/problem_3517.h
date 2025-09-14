#ifndef PROBLEM_3517_H
#define PROBLEM_3517_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3517 : public problem {
public:
    bool test() override;

    std::string smallestPalindrome(std::string s);
};



#endif //PROBLEM_3517_H

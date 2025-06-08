#ifndef PROBLEM_3_H
#define PROBLEM_3_H

#include "../problem.h"

#include <string>

class problem_3 : public problem
{
public:
    bool test() override;

    int lengthOfLongestSubstring(std::string s);
};



#endif //PROBLEM_3_H

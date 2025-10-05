#ifndef PROBLEM_1190_H
#define PROBLEM_1190_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1190 : public problem {
public:
    bool test() override;

    std::string reverseParentheses(std::string s);
};



#endif //PROBLEM_1190_H

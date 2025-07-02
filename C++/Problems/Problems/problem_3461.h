#ifndef PROBLEM_3461_H
#define PROBLEM_3461_H



#include "../problem.h"
#include <string>

class problem_3461 : public problem {
public:
    bool test() override;

    bool hasSameDigits(std::string s);
};



#endif //PROBLEM_3461_H

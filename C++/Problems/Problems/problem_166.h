#ifndef PROBLEM_166_H
#define PROBLEM_166_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_166: public problem {
public:
    bool test() override;

    std::string fractionToDecimal(int numerator, int denominator);
};



#endif //PROBLEM_166_H

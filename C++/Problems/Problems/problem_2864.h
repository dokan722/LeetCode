#ifndef PROBLEM_2864_H
#define PROBLEM_2864_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2864 : public problem {
public:
    bool test() override;

    std::string maximumOddBinaryNumber(std::string s);
};



#endif //PROBLEM_2864_H

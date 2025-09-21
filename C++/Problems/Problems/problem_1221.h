#ifndef PROBLEM_1221_H
#define PROBLEM_1221_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1221: public problem {
public:
    bool test() override;

    int balancedStringSplit(std::string s);
};



#endif //PROBLEM_1221_H

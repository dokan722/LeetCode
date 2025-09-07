#ifndef PROBLEM_1347_H
#define PROBLEM_1347_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1347 : public problem {
public:
    bool test() override;

    int minSteps(std::string s, std::string t);
};



#endif //PROBLEM_1347_H

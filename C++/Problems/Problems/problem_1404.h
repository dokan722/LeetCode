#ifndef PROBLEM_1404_H
#define PROBLEM_1404_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1404 : public problem {
public:
    bool test() override;

    int numSteps(std::string s);
};

#endif //PROBLEM_1404_H

#ifndef PROBLEM_2938_H
#define PROBLEM_2938_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2938 : public problem {
public:
    bool test() override;

    long long minimumSteps(std::string s);
};

#endif //PROBLEM_2938_H

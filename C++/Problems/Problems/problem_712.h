#ifndef PROBLEM_712_H
#define PROBLEM_712_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_712 : public problem {
public:
    bool test() override;

    int minimumDeleteSum(std::string s1, std::string s2);
};

#endif //PROBLEM_712_H

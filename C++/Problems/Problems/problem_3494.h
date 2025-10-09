#ifndef PROBLEM_3494_H
#define PROBLEM_3494_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3494 : public problem {
public:
    bool test() override;

    long long minTime(std::vector<int>& skill, std::vector<int>& mana);
};



#endif //PROBLEM_3494_H

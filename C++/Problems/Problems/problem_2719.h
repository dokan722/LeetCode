#ifndef PROBLEM_2719_H
#define PROBLEM_2719_H


#include "../problem.h"
#include <string>
#include <vector>

class problem_2719 : public problem {
public:
    bool test() override;

    long long minimumCost(std::string s);
};


#endif //PROBLEM_2719_H

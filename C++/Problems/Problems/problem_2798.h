#ifndef PROBLEM_2798_H
#define PROBLEM_2798_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2798 : public problem {
public:
    bool test() override;

    int numberOfEmployeesWhoMetTarget(std::vector<int>& hours, int target);
};



#endif //PROBLEM_2798_H

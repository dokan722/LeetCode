#ifndef PROBLEM_3423_H
#define PROBLEM_3423_H


#include <vector>

#include "../problem.h"

class problem_3423 : public problem
{
public:
    bool test() override;

    int maxAdjacentDistance(std::vector<int>& nums);
};




#endif //PROBLEM_3423_H

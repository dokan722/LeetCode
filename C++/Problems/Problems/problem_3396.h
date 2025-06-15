#ifndef PROBLEM_3396_H
#define PROBLEM_3396_H

#include "../problem.h"
#include <vector>


class problem_3396 : public problem
{
public:
    bool test() override;

    int minimumOperations(std::vector<int>& nums);
};



#endif //PROBLEM_3396_H

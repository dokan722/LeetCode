#ifndef PROBLEM_2656_H
#define PROBLEM_2656_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2656: public problem {
public:
    bool test() override;

    int maximizeSum(std::vector<int>& nums, int k);
};



#endif //PROBLEM_2656_H

#ifndef PROBLEM_2195_H
#define PROBLEM_2195_H


#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2195 : public problem {
public:
    bool test() override;

    long long minimalKSum(std::vector<int>& nums, int k);
};

#endif //PROBLEM_2195_H

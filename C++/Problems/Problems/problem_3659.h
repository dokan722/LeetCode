#ifndef PROBLEM_3659_H
#define PROBLEM_3659_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3659 : public problem {
public:
    bool test() override;

    bool partitionArray(std::vector<int>& nums, int k) ;
};

#endif //PROBLEM_3659_H

#ifndef PROBLEM_1800_H
#define PROBLEM_1800_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1800 : public problem {
public:
    bool test() override;

    int maxAscendingSum(std::vector<int>& nums);
};



#endif //PROBLEM_1800_H

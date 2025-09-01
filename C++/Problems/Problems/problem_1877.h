#ifndef PROBLEM_1877_H
#define PROBLEM_1877_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1877 : public problem {
public:
    bool test() override;

    int minPairSum(std::vector<int>& nums);
};



#endif //PROBLEM_1877_H

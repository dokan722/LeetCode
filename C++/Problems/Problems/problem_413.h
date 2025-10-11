#ifndef PROBLEM_413_H
#define PROBLEM_413_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_413 : public problem {
public:
    bool test() override;

    int numberOfArithmeticSlices(std::vector<int>& nums);
};



#endif //PROBLEM_413_H

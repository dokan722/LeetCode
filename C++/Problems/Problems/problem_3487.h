#ifndef PROBLEM_3487_H
#define PROBLEM_3487_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3487 : public problem {
public:
    bool test() override;

    int maxSum(std::vector<int>& nums);
};




#endif //PROBLEM_3487_H

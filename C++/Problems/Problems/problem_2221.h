#ifndef PROBLEM_2221_H
#define PROBLEM_2221_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2221: public problem {
public:
    bool test() override;

    int triangularSum(std::vector<int>& nums);
};



#endif //PROBLEM_2221_H

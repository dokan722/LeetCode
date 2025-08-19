#ifndef PROBLEM_2348_H
#define PROBLEM_2348_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2348 : public problem {
public:
    bool test() override;

    long long zeroFilledSubarray(std::vector<int>& nums);
};



#endif //PROBLEM_2348_H

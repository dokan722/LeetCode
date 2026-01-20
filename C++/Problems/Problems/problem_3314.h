#ifndef PROBLEM_3314_H
#define PROBLEM_3314_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3314 : public problem {
public:
    bool test() override;

    std::vector<int> minBitwiseArray(std::vector<int>& nums);
};

#endif //PROBLEM_3314_H

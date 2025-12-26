#ifndef PROBLEM_2104_H
#define PROBLEM_2104_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2104 : public problem {
public:
    bool test() override;

    long long subArrayRanges(std::vector<int>& nums);
};

#endif //PROBLEM_2104_H

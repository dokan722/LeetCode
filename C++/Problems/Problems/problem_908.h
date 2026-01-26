#ifndef PROBLEM_908_H
#define PROBLEM_908_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_908 : public problem {
public:
    bool test() override;

    int smallestRangeI(std::vector<int>& nums, int k) ;
};

#endif //PROBLEM_908_H

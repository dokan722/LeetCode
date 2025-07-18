#ifndef PROBLEM_2163_H
#define PROBLEM_2163_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_2163 : public problem {
public:
    bool test() override;

    long long minimumDifference(std::vector<int>& nums);
};



#endif //PROBLEM_2163_H

#ifndef PROBLEM_3804_H
#define PROBLEM_3804_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3804 : public problem {
public:
    bool test() override;

    int centeredSubarrays(std::vector<int>& nums);
};

#endif //PROBLEM_3804_H

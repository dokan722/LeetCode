#ifndef PROBLEM_2962_H
#define PROBLEM_2962_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2962 : public problem {
public:
    bool test() override;

    long long countSubarrays(std::vector<int>& nums, int k);
};



#endif //PROBLEM_2962_H

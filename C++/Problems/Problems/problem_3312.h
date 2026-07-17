#ifndef PROBLEM_3312_H
#define PROBLEM_3312_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_3312 : public problem {
public:
    bool test() override;

    std::vector<int> gcdValues(std::vector<int>& nums, std::vector<long long>& queries);
};

#endif //PROBLEM_3312_H

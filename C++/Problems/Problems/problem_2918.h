#ifndef PROBLEM_2918_H
#define PROBLEM_2918_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include<stack>
#include <queue>

class problem_2918 : public problem {
public:
    bool test() override;

    long long minSum(std::vector<int>& nums1, std::vector<int>& nums2);
};

#endif //PROBLEM_2918_H

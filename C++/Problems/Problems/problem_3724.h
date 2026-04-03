#ifndef PROBLEM_3724_H
#define PROBLEM_3724_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_3724 : public problem {
public:
    bool test() override;

    long long minOperations(std::vector<int>& nums1, std::vector<int>& nums2);
};

#endif //PROBLEM_3724_H

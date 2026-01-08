#ifndef PROBLEM_1458_H
#define PROBLEM_1458_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1458 : public problem {
public:
    bool test() override;

    int maxDotProduct(std::vector<int>& nums1, std::vector<int>& nums2);
};

#endif //PROBLEM_1458_H

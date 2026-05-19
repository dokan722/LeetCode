#ifndef PROBLEMS_PROBLEM_2540_H
#define PROBLEMS_PROBLEM_2540_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>
#include <cmath>

class problem_2540 : public problem {
public:
    bool test() override;

    int getCommon(std::vector<int>& nums1, std::vector<int>& nums2);
};

#endif //PROBLEMS_PROBLEM_2540_H
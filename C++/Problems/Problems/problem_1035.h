#ifndef PROBLEM_1035_H
#define PROBLEM_1035_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_1035 : public problem {
public:
    bool test() override;

    int maxUncrossedLines(std::vector<int>& nums1, std::vector<int>& nums2);
};

#endif //PROBLEM_1035_H

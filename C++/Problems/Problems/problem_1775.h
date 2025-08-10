#ifndef PROBLEM_1775_H
#define PROBLEM_1775_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1775 : public problem {
public:
    bool test() override;

    int minOperations(std::vector<int>& nums1, std::vector<int>& nums2);
};



#endif //PROBLEM_1775_H

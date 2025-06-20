#ifndef PROBLEM_1855_H
#define PROBLEM_1855_H



#include "../problem.h"
#include <vector>


class problem_1855 : public problem {
public:
    bool test() override;

    int maxDistance(std::vector<int>& nums1, std::vector<int>& nums2);
};



#endif //PROBLEM_1855_H

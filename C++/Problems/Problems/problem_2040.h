
#ifndef PROBLEM_2040_H
#define PROBLEM_2040_H



#include "../problem.h"
#include <vector>


class problem_2040 : public problem {
public:
    bool test() override;

    long long kthSmallestProduct(std::vector<int>& nums1, std::vector<int>& nums2, long long k);
private:
    int countSmaller(std::vector<int> &nums, long long f, long long v);
};



#endif //PROBLEM_2040_H

#ifndef PROBLEM_2425_H
#define PROBLEM_2425_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2425 : public problem {
public:
    bool test() override;

    int xorAllNums(std::vector<int>& nums1, std::vector<int>& nums2);
};

#endif //PROBLEM_2425_H

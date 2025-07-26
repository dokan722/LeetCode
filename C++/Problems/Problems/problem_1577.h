#ifndef PROBLEM_1577_H
#define PROBLEM_1577_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1577 : public problem {
public:
    bool test() override;

    int numTriplets(std::vector<int>& nums1, std::vector<int>& nums2);
};



#endif //PROBLEM_1577_H

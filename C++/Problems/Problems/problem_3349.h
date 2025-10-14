#ifndef PROBLEM_3349_H
#define PROBLEM_3349_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3349 : public problem {
public:
    bool test() override;

    bool hasIncreasingSubarrays(std::vector<int>& nums, int k);
};



#endif //PROBLEM_3349_H

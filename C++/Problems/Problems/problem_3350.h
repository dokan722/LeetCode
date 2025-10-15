#ifndef PROBLEM_3350_H
#define PROBLEM_3350_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3350 : public problem {
public:
    bool test() override;

    int maxIncreasingSubarrays(std::vector<int>& nums);
};



#endif //PROBLEM_3350_H

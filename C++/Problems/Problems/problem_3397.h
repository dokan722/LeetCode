#ifndef PROBLEM_3397_H
#define PROBLEM_3397_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3397 : public problem {
public:
    bool test() override;

    int maxDistinctElements(std::vector<int>& nums, int k);
};



#endif //PROBLEM_3397_H

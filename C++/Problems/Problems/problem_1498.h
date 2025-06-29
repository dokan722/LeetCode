#ifndef PROBLEM_1498_H
#define PROBLEM_1498_H


#include "../problem.h"
#include <vector>

class problem_1498 : public problem {
public:
    bool test() override;

    int numSubseq(std::vector<int>& nums, int target);
};




#endif //PROBLEM_1498_H

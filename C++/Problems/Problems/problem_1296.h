#ifndef PROBLEM_1296_H
#define PROBLEM_1296_H

#include "../problem.h"
#include <vector>

class problem_1296 : public problem {
public:
    bool test() override;

    bool isPossibleDivide(std::vector<int>& nums, int k);
};



#endif //PROBLEM_1296_H

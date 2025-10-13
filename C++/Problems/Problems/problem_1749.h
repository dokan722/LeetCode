#ifndef PROBLEM_1749_H
#define PROBLEM_1749_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1749 : public problem {
public:
    bool test() override;

    int maxAbsoluteSum(std::vector<int>& nums);
};



#endif //PROBLEM_1749_H

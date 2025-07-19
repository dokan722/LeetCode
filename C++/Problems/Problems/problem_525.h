#ifndef PROBLEM_525_H
#define PROBLEM_525_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_525 : public problem {
public:
    bool test() override;

    int findMaxLength(std::vector<int>& nums);
};



#endif //PROBLEM_525_H

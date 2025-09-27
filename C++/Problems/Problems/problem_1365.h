#ifndef PROBLEM_1365_H
#define PROBLEM_1365_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_1365: public problem {
public:
    bool test() override;

    std::vector<int> smallerNumbersThanCurrent(std::vector<int>& nums);
};



#endif //PROBLEM_1365_H

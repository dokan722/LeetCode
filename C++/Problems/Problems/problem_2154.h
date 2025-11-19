#ifndef PROBLEM_2154_H
#define PROBLEM_2154_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_2154 : public problem {
public:
    bool test() override;

    int findFinalValue(std::vector<int>& nums, int original);
};



#endif //PROBLEM_2154_H

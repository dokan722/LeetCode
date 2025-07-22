#ifndef PROBLEM_1695_H
#define PROBLEM_1695_H

#include "../problem.h"
#include <vector>
#include <string>

class problem_1695 : public problem {
public:
    bool test() override;

    int maximumUniqueSubarray(std::vector<int>& nums);
};



#endif //PROBLEM_1695_H

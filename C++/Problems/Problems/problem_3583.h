#ifndef PROBLEM_3583_H
#define PROBLEM_3583_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3583 : public problem {
public:
    bool test() override;

    int specialTriplets(std::vector<int>& nums);
};

#endif //PROBLEM_3583_H

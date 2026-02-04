#ifndef PROBLEM_3818_H
#define PROBLEM_3818_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3818 : public problem {
public:
    bool test() override;

    int minimumPrefixLength(std::vector<int>& nums);
};

#endif //PROBLEM_3818_H

#ifndef PROBLEM_3379_H
#define PROBLEM_3379_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3379 : public problem {
public:
    bool test() override;

    std::vector<int> constructTransformedArray(std::vector<int>& nums);
};

#endif //PROBLEM_3379_H

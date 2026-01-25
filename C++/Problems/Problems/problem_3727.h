#ifndef PROBLEM_3727_H
#define PROBLEM_3727_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_3727 : public problem {
public:
    bool test() override;

    long long maxAlternatingSum(std::vector<int>& nums);
};

#endif //PROBLEM_3727_H
